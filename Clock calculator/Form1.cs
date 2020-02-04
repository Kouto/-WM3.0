using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_calculator
{
    public partial class Form1 : Form
    {
        #region для облегчения работы с GUI

        class GuiHelper
        {
            public readonly List<Control> parents;
            public readonly List<Control> childs;
            public readonly List<Control> all;

            public GuiHelper(Control parent, Control child) : this(new List<Control>() { parent }, new List<Control>() { child }) { }

            public GuiHelper(Control parent, List<Control> childs) : this(new List<Control>() { parent }, childs) { }

            GuiHelper(List<Control> parents, List<Control> childs)
            {
                this.parents = parents;
                this.childs = childs;

                all = new List<Control>();
                all.AddRange(parents.ToArray());
                all.AddRange(childs.ToArray());
            }
        }

        /// <summary>
        /// список связей
        /// </summary>
        private readonly List<GuiHelper> GuiHelpers = new List<GuiHelper>();

        /// <summary>
        /// подпрограмма для включения жлементам по связям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkInGUIHelpers(object sender, EventArgs _)
        {
            void disableCntrl(Control desCntrl)
            {
                Debug.Print($"dis {desCntrl.GetType()} {desCntrl.Name}");

                if (desCntrl is NumericUpDown munUpDwn) munUpDwn.Value = munUpDwn.Minimum;
                if (desCntrl is CheckBox chkBox) chkBox.Checked = false;
                if (desCntrl is RadioButton rdBnt) rdBnt.Checked = false;
                if (desCntrl is CheckedListBox chkList)
                {
                    for (int i = 0; i < chkList.Items.Count; i++)
                        chkList.SetItemChecked(i, false);

                    chkList.BackColor = Color.FromKnownColor(KnownColor.Control);
                }
                if (desCntrl is Panel panel)
                {
                    foreach (Control desCntrlEl in panel.Controls) disableCntrl(desCntrlEl);
                    desCntrl.Enabled = false;
                }
                if (desCntrl is GroupBox grpBox)
                {
                    foreach (Control desCntrlEl in grpBox.Controls) disableCntrl(desCntrlEl);
                    //desCntrl.Enabled = false;
                }
            }

            Control control = (Control)sender;

            GuiHelper gui = GuiHelpers.FirstOrDefault(el => el.all.Contains(control));

            if (gui is null)
                return;

            if (gui.parents.Contains(control))
            {
                // enable
                if (control is CheckBox ||
                    control is RadioButton)
                {
                    bool check = (control is CheckBox) ?
                                 ((CheckBox)control).Checked :
                                 ((RadioButton)control).Checked;

                    if (check)
                    {
                        foreach (Control child in gui.childs)
                        {
                            child.Enabled = true;

                            if (child.GetType() == typeof(CheckedListBox))
                                ((CheckedListBox)child).BackColor = Color.FromKnownColor(KnownColor.Window);

                            Debug.Print($"ena {child.GetType()} {child.Name}");

                        }
                        // передадим фокус вводу значения
                        gui.childs.FirstOrDefault(el => el.GetType() == typeof(NumericUpDown))?.Focus();
                    }
                    else
                    {
                        foreach (Control child in gui.childs)
                        {
                            // выключим внутренние элемент
                            disableCntrl(child);

                            child.Enabled = false;
                        }
                    }
                }
            }
        }

        readonly List<WorkTypeSub> workTypes = new List<WorkTypeSub>();

        #endregion

        bool detailLog = false;

        public Form1()
        {
            InitializeComponent();

            // заполним список связями
            GuiHelpers = new List<GuiHelper>()
            {
                new GuiHelper(chkThread_2_wood, new List<Control>(){ chkThread_2_wood_only, chkThread_2_wood_reils }),
                new GuiHelper(chkThread_2_PVH, new List<Control>(){ chkThread_2_PVH_only, chkThread_2_PVH_reils }),

                new GuiHelper(chkMosquito_door, numMosq_door),
                new GuiHelper(chkMosquito_border, numMosq_border),
                new GuiHelper(chkMosquito_pliss, numMosq_pliss),
                new GuiHelper(chkMosquito_slide, numMosq_slide),

                new GuiHelper(rbUchimado_silicon, lstMountingSeamSilicon),
                new GuiHelper(rbReplace_foam, lstReplaceFoamSilicon),
                new GuiHelper(rbReplace_PSUL, lstReplacePsulSilicon),

                new GuiHelper(chkPrimat, numPrimat),

                new GuiHelper(chkTypeOfFastening, pnlTypeOfFastening),

                new GuiHelper(chkInstallationConditions, pnlInstallationConditions),

                new GuiHelper(chkMountingMethod, pnlMountingMethod),

                new GuiHelper(chkJoinProfil2, numJoinProfil2),
                new GuiHelper(chkJoinProfil20, numJoinProfil20),
                new GuiHelper(chlPilastra, numPilastra),

                new GuiHelper(btnUchimado, pnlUchimado),
                new GuiHelper(btnReplacement, pnlReplacement),

                new GuiHelper(chkMosquitos, pnlMosquitos),

                new GuiHelper(chkDismantling, pnlDismantling),

                new GuiHelper(chkOther, pnlOther),
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // подписываемся на событие изменения состава этажей
            FloorCollection.evRefresh += FloorCollection_evRefresh;

            Disposed += (s1, e1) =>
            {
                // отписываемся от события изменения состава этажей
                FloorCollection.evRefresh -= FloorCollection_evRefresh;
            };

            workTypes.Add(new WorkTypeSub(WorkType.Uchimado, rbUchimado_silicon, "Силикон", new List<long> { 200, 201 }));
            workTypes.Add(new WorkTypeSub(WorkType.Uchimado, rbUchimado_PSUL, "ПСУЛ illmond"));
            workTypes.Add(new WorkTypeSub(WorkType.Uchimado, rbUchimado_free, "Без монтажа"));

            workTypes.Add(new WorkTypeSub(WorkType.Replace, btnReplacement, "Монтажная пена", new List<long>() { 301, 302, 303, 304 }));
            workTypes.Add(new WorkTypeSub(WorkType.Replace, rbReplace_PSUL, "ПСУЛ illmond", new List<long>() { 301, 302 }));
            workTypes.Add(new WorkTypeSub(WorkType.Replace, rbReplace_free, "Без монтажа"));
        }

        private void FloorCollection_evRefresh(object sender, EventArgs e)
        {
            #region потокобезопасность

            if (InvokeRequired)
            {
                Invoke(new Action(() => FloorCollection_evRefresh(sender, e)));
                return;
            }

            #endregion

            // очистим таблицу
            grdFloors.Rows.Clear();

            foreach (Floor floor in FloorCollection.floors)
            {
                // добавим строку
                grdFloors.Rows.Add(floor.number,
                                   floor.cnt,
                                   floor.perimeter);

                // запомним этаж в строке
                grdFloors.Rows[grdFloors.Rows.Count - 1].Tag = floor;
            }

            // выведем итого
            txtFloorsCnt.Text = FloorCollection.fullCnt.ToString();
            txtFloorsNum.Text = FloorCollection.floors.Count.ToString();
            txtFloorsPerimeter.Text = FloorCollection.fullPerimeter.ToString();
        }

        private void BtnDelFloor_Click(object sender, EventArgs e)
        {
            // проверка выбора строки
            if (grdFloors.CurrentCell is null ||
                grdFloors.CurrentCell.RowIndex == -1)
                return;

            // считываем этаж
            Floor floor = grdFloors.Rows[grdFloors.CurrentCell.RowIndex].Tag as Floor;

            // уточним про удаление
            if (MessageBox.Show($"Вы уверены что хотите удалить этаж {floor.number}?", 
                                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            // удаляем этаж
            FloorCollection.delFloor(floor);
        }

        private void BtnAddFloor_Click(object sender, EventArgs e)
        {
            using (frmFloor frm = new frmFloor())
            {
                while (frm.ShowDialog() == DialogResult.OK)
                {
                    if (!float.TryParse(frm.txtPerimeter.Text.Replace(".", ","), out float perimeter))
                    {
                        MessageBox.Show("Ошибка в периметре", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        continue;
                    }

                    if (!FloorCollection.addFloor((int)frm.numNumber.Value,
                                                  (int)frm.numCnt.Value,
                                                  perimeter))
                        continue;

                    break;
                }
            }
        }

        /// <summary>
        /// базовый шрифт для pdf
        /// </summary>
        static readonly BaseFont baseFnt = BaseFont.CreateFont($"{Directory.GetCurrentDirectory()}\\times.ttf",
                                                                  BaseFont.IDENTITY_H,
                                                                  BaseFont.EMBEDDED);

        /// <summary>
        /// Обычный шрифт для pdf документов
        /// </summary>
        static readonly iTextSharp.text.Font fnt = new iTextSharp.text.Font(baseFnt,
                                                                   12.0f,
                                                                   iTextSharp.text.Font.NORMAL,
                                                                   new BaseColor(Color.Black));

        /// <summary>
        /// Жирный шрифт для pdf документов
        /// </summary>
        static readonly iTextSharp.text.Font fntB = new iTextSharp.text.Font(baseFnt,
                                                                    12.0f,
                                                                    iTextSharp.text.Font.BOLD,
                                                                    new BaseColor(Color.Black));

        static readonly iTextSharp.text.Font fnt14 = new iTextSharp.text.Font(baseFnt,
                                                                              14.0f,
                                                                              iTextSharp.text.Font.NORMAL,
                                                                              new BaseColor(Color.Black));

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            // файл проекта
            string fileName = string.Empty;

            #region указания пути сохранения

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.FileName = $"{txtCustomer.Text}.pdf";
                dlg.Filter = "PDF файлы|*.pdf";

                if (dlg.ShowDialog() == DialogResult.OK)
                    fileName = dlg.FileName;
                else
                    return;
            }

            #endregion

            lstReport.Items.Clear();
            dicSummaryList.Clear();

            try
            {
                // pdf документ
                var pdfDoc = new Document();

                #region открываем документ

                try
                {
                    PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.OpenOrCreate));
                    pdfDoc.Open();
                }
                catch (Exception ex)
                {
                    Logger.logCalculator.Error(ex, $"Ошибка создания PDF файла по пути: {fileName}");

                    MessageBox.Show("Ошибка создания PDF файла", "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return;
                } 

                #endregion

                void addLineCenter(string line)
                {
                    Chunk beginning = new Chunk(line, fntB);

                    Phrase p1 = new Phrase(beginning);

                    Paragraph p = new Paragraph()
                    {
                        Alignment = Element.ALIGN_CENTER,
                    };

                    p.Add(p1);

                    pdfDoc.Add(p);
                }

                void addLine(string firtsString, bool firstStringIsBold = false,
                             string secondString = "", bool secondStringIsBold = false)
                {
                    Chunk chunk1 = new Chunk(firtsString, firstStringIsBold ? fntB : fnt);
                    Chunk chunk2 = new Chunk(secondString, secondStringIsBold ? fntB : fnt);

                    if (secondString.ToLower() == "есть")
                    {
                        chunk2.SetBackground(BaseColor.GREEN);
                    }

                    Phrase phrase1 = new Phrase(chunk1);
                    Phrase phrase2 = new Phrase(chunk2);

                    Paragraph paragraph = new Paragraph
                    {
                        phrase1,
                        phrase2
                    };

                    pdfDoc.Add(paragraph);
                }

                void addItogo(string summ)
                {
                    Chunk chunk1 = new Chunk(summ, fnt14);
                    chunk1.SetBackground(BaseColor.GREEN);

                    Phrase phrase1 = new Phrase(chunk1);

                    Paragraph paragraph = new Paragraph
                    {
                        phrase1,
                    };

                    pdfDoc.Add(paragraph);
                }


                #region магия перебора элементов

                void recurseControls(Control controlIn, string left)
                {
                    void addCalc(Settings.Item item, float count)
                    {
                        if (detailLog)
                            lstReport.Items.Add($"    ** {item.name}");

                        dicSummaryList.Add(item, count);
                    }

                    void printCalc(Control cntrl)
                    {
                        if (cntrl.Tag is null ||
                            !cntrl.Enabled)
                            return;

                        string[] arr = cntrl.Tag.ToString().Split(',');

                        if (cntrl is CheckedListBox box)
                        {
                            #region обработка списка

                            for (int i = 0; i < box.Items.Count; i++)
                            {
                                if (!box.GetItemChecked(i))
                                    continue;

                                if (!int.TryParse(arr[i], out int id) ||
                                    id < 0)
                                    continue;

                                Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                if (item is null)
                                    continue;

                                addCalc(item, 1);
                            }

                            #endregion
                        }
                        else if (cntrl is RadioButton rdBtn &&
                                rdBtn.Checked)
                        {
                            foreach (string el in arr)
                            {
                                if (!int.TryParse(el, out int id) ||
                                   id < 0)
                                    continue;

                                Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                if (item is null)
                                    continue;

                                addCalc(item, 1);
                            }
                        }
                        else if (cntrl is NumericUpDown numeric)
                        {
                            foreach (string el in arr)
                            {
                                if (!int.TryParse(el, out int id) ||
                                   id < 0)
                                    continue;

                                Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                if (item is null)
                                    continue;

                                addCalc(item, (float)numeric.Value);
                            }
                        }
                        else if (cntrl is CheckBox checkBox &&
                                 checkBox.Checked)
                        {
                            GuiHelper guiHelper = GuiHelpers.FirstOrDefault(el => el.all.Contains(checkBox));

                            float count = 1;

                            if (!(guiHelper == null))
                            {
                                NumericUpDown updwn = (NumericUpDown)guiHelper.childs.FirstOrDefault(el => el.GetType() == typeof(NumericUpDown));

                                if (!(updwn is null))
                                    count = (float)updwn.Value;

                                if (guiHelper.all.Contains(checkBox))
                                {
                                    // как дочерний
                                    foreach (string el in arr)
                                    {
                                        if (!int.TryParse(el, out int id) ||
                                           id < 0)
                                            continue;

                                        Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                        if (item is null)
                                            continue;

                                        addCalc(item, count);
                                    }
                                }
                            }
                            else
                            {
                                foreach (string el in arr)
                                {
                                    if (!int.TryParse(el, out int id) ||
                                       id < 0)
                                        continue;

                                    Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                    if (item is null)
                                        continue;

                                    addCalc(item, count);
                                }
                            }
                        }
                    }

                    if (!controlIn.Enabled)
                        return;

                    printCalc(controlIn);

                    if (controlIn is GroupBox ||
                        controlIn is Panel)
                    {
                        foreach (Control control in controlIn.Controls)
                        {
                            recurseControls(control, $"{left}  ");
                        }

                        return;
                    }
                }

                foreach (Control control in Controls)
                {
                    recurseControls(control, string.Empty);
                }

                #endregion

                #region проверка

                WorkTypeSub typeSub = workTypes.FirstOrDefault(el => el.button.Checked);

                if (typeSub is null)
                {
                    MessageBox.Show("Вы не выбрали вид работ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                #endregion

                addLineCenter("Расчет монтажных часов");
                addLine("Наименование заказчика: ", true, txtCustomer.Text, false);
                addLine("Условия при расчете:", true, string.Empty, false);
                addLine($"Вид работ: ", true, typeSub.workType == WorkType.Replace ? "замена" : "учимадо", false);

                #region шапка

                List<long> dicIDS = dicSummaryList.Select(el => el.Key.id).ToList();

                foreach (ActionInTop actionInTop in ActionInTop.Collection)
                {
                    string line = actionInTop.outType == ActionInTop.OutType.Percent ? string.Empty : $"{actionInTop.text}: ";
                    if (actionInTop.outType == ActionInTop.OutType.Bool)
                    {
                        line += $"{(dicIDS.Contains(actionInTop.ids[0]) ? "есть" : "нет")}";
                    }
                    else if (actionInTop.outType == ActionInTop.OutType.Count)
                    {
                        line += $"{(dicIDS.Contains(actionInTop.ids[0]) ? $"{dicSummaryList.FirstOrDefault(el => el.Key.id == actionInTop.ids[0]).Value.ToString()} шт." : "нет")}";
                    }
                    else if (actionInTop.outType == ActionInTop.OutType.Text)
                    {
                        List<long> intersect = dicIDS.Intersect(actionInTop.ids).ToList();

                        if (intersect.Count > 0)
                        {
                            line += string.Join(", ", Settings.settings.items.Where(el1 => intersect.Contains(el1.id)).Select(el1 => el1.name));
                        }

                    }
                    else if (actionInTop.outType == ActionInTop.OutType.Percent)
                    {
                        if (!dicIDS.Contains(actionInTop.ids[0]))
                        {
                            line = $"{actionInTop.text}: нет";
                        }
                        else
                        {
                            Settings.Item percentItem = Settings.settings.items.FirstOrDefault(el => el.id == actionInTop.ids[0]);
                            line = $"{actionInTop.text} ({percentItem.value}): есть";
                        }
                    }
                    else if (actionInTop.outType == ActionInTop.OutType.TextAndCoutn)
                    {
                        List<long> intersect = dicIDS.Intersect(actionInTop.ids).ToList();

                        if (intersect.Count == 0)
                        {
                            line = $"{actionInTop.text}: нет";
                        }
                        else
                        {
                            line = $"{actionInTop.text}: есть, {dicSummaryList.Where(el => intersect.Contains(el.Key.id)).Select(el => (int)el.Value).ToList().Sum()} шт.";
                        }
                    }

                    addLine(line, false, string.Empty, false);

                }

                #endregion

                #region очищаем и сортируем

                dicSummaryList = dicSummaryList.
                                 // фильтр по не нужным данным
                                 Where(el => el.Key.seconds > 0)
                                 .OrderBy(el => el.Key.id)
                                 .ToDictionary(el => el.Key, el => el.Value);

                #endregion

                ///общее время в секундах на все работы
                long seconds = 0;

                long sec_mounting = 0;
                long sec_demounting = 0;

                #region монтаж изделий

                {
                    var dic = dicSummaryList
                                  .Where(el => el.Key.actionType == Settings.Item.ActionType.FloorInstallation)
                                  //.OrderBy(el => el.Key.id)
                                  .ToDictionary(el => el.Key, el => el.Value);

                    if (dic.Count > 0)
                    {
                        // добавим пустышку перед
                        addLine(" ");
                        // выведем о том, что это есть
                        addLine(Settings.Item.dicActionTypeTextes[Settings.Item.ActionType.FloorInstallation], true, string.Empty, false);

                        foreach (Floor floor in FloorCollection.floors)
                        {
                            // вермя работя для этажа
                            long scnds = 0;

                            if (detailLog)
                                lstReport.Items.Add($"    *Этаж {floor.number}, изд. {floor.cnt}, периметр {floor.perimeter}");

                            // список настроек и кол-ва
                            foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                            {
                                // кол-во век. на этаж для выбранного действия
                                long scndsFloorAction = (long)(floor.perimeter / Settings.k * kItem.Key.seconds);

                                // кол-во секунд
                                scnds += scndsFloorAction;

                                if (detailLog)
                                    lstReport.Items.Add($"      *{kItem.Key.name}. {floor.perimeter} п.м. / {Settings.k} * {kItem.Key.seconds} сек. = {scndsFloorAction} сек.");
                            }

                            // подъем на этаж
                            {
                                if (!dicIDS.Contains(Settings.settings.UchimadoFree.id) &&
                                    !dicIDS.Contains(Settings.settings.ReplaceFree.id))
                                {

                                    // кол-во век. на этаж для выбранного действия
                                    long scndsFloorAction = (long)(floor.perimeter / Settings.k * Settings.settings.RiseToTheFloor.seconds * Math.Abs(floor.number));

                                    // кол-во секунд
                                    scnds += scndsFloorAction;

                                    if (detailLog)
                                        lstReport.Items.Add($"      *{Settings.settings.RiseToTheFloor.name}. {floor.perimeter} п.м. / {Settings.k} * {Settings.settings.RiseToTheFloor.seconds} сек. * {Math.Abs(floor.number)} №№ = {scndsFloorAction} сек.");
                                }
                            }

                            if (detailLog)
                                lstReport.Items.Add($"    *Итого: {scnds} сек.");

                            addLine($"  Для {floor.number}-го этажа, {floor.cnt} шт. {floor.perimeter} п.м. понадобится {Settings.Item.getStringTime(scnds, false)}");

                            seconds += scnds;
                            sec_mounting += scnds;
                        }
                    }
                }

                #endregion

                #region монтаж москитных сеток

                {
                    var dic = dicSummaryList
                                  .Where(el => el.Key.actionType == Settings.Item.ActionType.InstallationOfMosquitoNets)
                                  //.OrderBy(el => el.Key.id)
                                  .ToDictionary(el => el.Key, el => el.Value);

                    if (dic.Count > 0)
                    {
                        addLine(" ");
                        // выведем о том, что это есть
                        addLine(Settings.Item.dicActionTypeTextes[Settings.Item.ActionType.InstallationOfMosquitoNets], true);

                        // список настроек и кол-ва
                        foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                        {
                            // кол-во секунд
                            long scnds = (long)(kItem.Key.seconds * kItem.Value);

                            if (detailLog)
                                lstReport.Items.Add($"    *{kItem.Key.name}. {kItem.Key.seconds} за ед. * {kItem.Value} шт. = {scnds} сек.");

                            addLine($"  {kItem.Key.name}, {kItem.Value} шт. понадобится {Settings.Item.getStringTime(scnds, false)}");

                            seconds += scnds;
                            sec_mounting += scnds;
                        }
                    }
                }

                #endregion

                #region демонтаж

                {
                    var dic = dicSummaryList
                                  .Where(el => el.Key.actionType == Settings.Item.ActionType.Dismantling)
                                  //.OrderBy(el => el.Key.id)
                                  .ToDictionary(el => el.Key, el => el.Value);

                    if (dic.Count > 0)
                    {
                        addLine(" ");

                        // выведем о том, что это есть
                        addLine(Settings.Item.dicActionTypeTextes[Settings.Item.ActionType.Dismantling], true);

                        // найдена группа
                        bool isGrp = false;

                        // общее время для группы
                        long grpSeconds = 0;

                        // список идентификаторов
                        List<long> ids = dic.Select(el => el.Key.id).ToList();

                        // список идентификаторов которые уже были выведены в объединениях
                        List<long> ids_in_grps = new List<long>();

                        // обработанные группы
                        List<Settings.ItemGroup> usedGrups = new List<Settings.ItemGroup>();

                        // список настроек и кол-ва
                        foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                        {
                            isGrp = false;
                            grpSeconds = 0;

                            // проверяем на обработку в группе
                            if (ids_in_grps.Contains(kItem.Key.id))
                                // уже было обработано
                                continue;

                            #region обработка объединений
                            if (Settings.idsInGroups.Contains(kItem.Key.id))
                            {
                                // эта операция учавствует в объединении

                                // поиск операции которая еще не использовалась и есть нужная операции, включая текущую
                                Settings.ItemGroup grp = Settings.itemGroups.FirstOrDefault(el => !usedGrups.Contains(el) && el.ids.Intersect(ids).Count() == el.ids.Count);

                                if (!(grp is null))
                                {
                                    // нйдена группа для которой есть все идентификаторы

                                    // выводим название операции
                                    addLine($"  {grp.text}");
                                    isGrp = true;

                                    // суммируем общее кол-во секунд
                                    grpSeconds = dic
                                                 .Where(el => grp.ids.Contains(el.Key.id))
                                                 .Select(el => el.Key.seconds)
                                                 .Sum();

                                    // добавляем в список обработанных
                                    ids_in_grps.AddRange(grp.ids.ToArray());

                                    // добавим как обработанную группу
                                    usedGrups.Add(grp);
                                }
                            }
                            #endregion

                            // вывод в отчет
                            if (!isGrp)
                                addLine($"  {kItem.Key.name}");

                            foreach (Floor floor in FloorCollection.floors)
                            {
                                // кол-во секунд = время на операцию * периметр / 4.8
                                long scnds = (long)((!isGrp ? kItem.Key.seconds : grpSeconds) * floor.perimeter / Settings.k);

                                addLine($"    Для {floor.number}-го этажа, {floor.cnt} шт. {floor.perimeter} п.м. понадобится {Settings.Item.getStringTime(scnds, false)}");

                                seconds += scnds;
                                sec_demounting += scnds;
                            }
                        }

                        lstReport.Items.Add(string.Empty);
                    }
                }

                #endregion

                #region прочее

                {
                    var dic = dicSummaryList
                              .Where(el => el.Key.actionType == Settings.Item.ActionType.GlassClear ||
                                           el.Key.actionType == Settings.Item.ActionType.ClearWorkplace ||
                                           el.Key.actionType == Settings.Item.ActionType.PrepareWorkplace ||
                                           el.Key.actionType == Settings.Item.ActionType.Other)
                              .ToDictionary(el => el.Key, el => el.Value);

                    if (dic.Count > 0)
                    {
                        addLine(" ");
                        addLine("Прочее", true);

                        foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                        {
                            long scnds = 0;

                            if (kItem.Key.actionType == Settings.Item.ActionType.GlassClear)
                            {
                                scnds = (long)(kItem.Key.seconds * FloorCollection.fullPerimeter / Settings.k);

                                addLine($"  {kItem.Key.name} {FloorCollection.fullCnt} шт. понадобится {Settings.Item.getStringTime(scnds, false)}");
                            }
                            else if (kItem.Key.actionType == Settings.Item.ActionType.ClearWorkplace)
                            {
                                scnds = FloorCollection.fullCnt * kItem.Key.seconds;

                                addLine($"  На уборку рабочего места понадобится {Settings.Item.getStringTime(scnds, false)}");
                            }
                            else if (kItem.Key.actionType == Settings.Item.ActionType.PrepareWorkplace)
                            {
                                scnds = FloorCollection.fullCnt * kItem.Key.seconds;

                                addLine($"  На подготовку рабочего места понадобится {Settings.Item.getStringTime(scnds, false)}");
                            }
                            else if (kItem.Key.actionType == Settings.Item.ActionType.Other)
                            {
                                scnds = (long)(kItem.Value * kItem.Key.seconds);

                                addLine($"  {kItem.Key.name} {kItem.Value} понадобится {Settings.Item.getStringTime(scnds, false)}");
                            }
                            else
                            {
                                Logger.logCalculator.Error($"Не обработанный элемент в \"Прочее\" #{kItem.Key.id}");
                                MessageBox.Show($"Не обработанный элемент в \"Прочее\" #{kItem.Key.id}", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            seconds += scnds;
                            sec_mounting += scnds;
                        }
                    }
                }

                #endregion

                // Вывод итого
                addLine(" ");
                addLine($"Итого", true);
                if (sec_demounting > 0) addLine($"  На демонтаж понадобится {Settings.Item.getStringTime(sec_demounting, false)}");
                if (sec_mounting > 0) addLine($"  На монтаж понадобится {Settings.Item.getStringTime(sec_mounting, false)}");

                if (dicIDS.Contains(Settings.settings.Rain.id))
                {
                    long secPercent = (long)(sec_mounting / 100.0 * Settings.settings.Rain.percent);
                    addLine($"  На монтаж в дождливую погоду понадобится еще {Settings.Item.getStringTime(secPercent, false)}");

                    sec_mounting += secPercent;
                }

                addLine($"Всего на монтаж и демонтаж {FloorCollection.fullCnt} изделий {FloorCollection.fullPerimeter} м.п. понадобится:");
                addLine($"  {Settings.Item.getStringTime(sec_demounting + sec_mounting, false)} (24-часовой график)");
                //addLine($"{Settings.Item.getStringTime(sec_demounting + sec_mounting, true)} (8-часовой график)");
                addItogo($"  {Settings.Item.getStringTime(sec_demounting + sec_mounting, true)} (8-часовой график)");

                #region footer

                {
                    pdfDoc.Add(new Paragraph(" ", fnt));
                    pdfDoc.Add(new Paragraph(" ", fnt));
                    
                    PdfPTable table = new PdfPTable(new float[] { 1.0f })
                    {
                        WidthPercentage = 100.0f,
                    };
                    PdfPCell cell = new PdfPCell()
                    {
                        BorderColorLeft = new BaseColor(255, 255, 255),
                        BorderColorTop = new BaseColor(255, 255, 255),
                        BorderColorRight = new BaseColor(255, 255, 255),
                        BorderColorBottom = new BaseColor(0, 0, 0),
                    };
                    table.AddCell(cell);
                    pdfDoc.Add(table);

                    pdfDoc.Add(new Paragraph("В расчет не включены:", fntB));
                    pdfDoc.Add(new Paragraph(" - Затраты на приемку и проверку груза;", fnt));
                    pdfDoc.Add(new Paragraph(" - Закупка материалов для монтажа;", fnt));
                    pdfDoc.Add(new Paragraph(" - Логистика.", fnt));
                    pdfDoc.Add(new Paragraph($"Дата расчета: {DateTime.Now.ToString("d MMMM yyyy г.")}", fntB));
                }

                #endregion

                // закрываем документ
                pdfDoc.Close();
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex, "Ошибка сохранения PDF файла");

                MessageBox.Show("Ошибка сохранения PDF файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }

        private void groupBoxPaint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.SaddleBrown, Color.Blue);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);

                int Y = (int)(strSize.Height / 2) + (string.IsNullOrEmpty(box.Text) ? 7 : 0);

                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + Y,
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - Y - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        // справочник операция / кол-во
        Dictionary<Settings.Item, float> dicSummaryList = new Dictionary<Settings.Item, float>();

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomer.Text))
            {
                MessageBox.Show("Вы не ввели заказчика", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCustomer.Focus();

                return;
            }

            lstReport.Items.Clear();
            dicSummaryList.Clear();

            #region магия перебора элементов

            void recurseControls(Control controlIn, string left)
            {
                void addCalc(Settings.Item item, float count)
                {
                    //lstReport.Items.Add($"{item.name} {item.value} * {count}");

                    dicSummaryList.Add(item, count);

                }

                void printCalc(Control cntrl)
                {
                    if (cntrl.Tag is null ||
                        !cntrl.Enabled)
                        return;

                    string[] arr = cntrl.Tag.ToString().Split(',');

                    if (cntrl is CheckedListBox box)
                    {
                        #region обработка списка

                        for (int i = 0; i < box.Items.Count; i++)
                        {
                            if (!box.GetItemChecked(i))
                                continue;

                            if (!int.TryParse(arr[i], out int id) ||
                                id < 0)
                                continue;

                            Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                            if (item is null)
                                continue;

                            addCalc(item, 1);
                        }

                        #endregion
                    }
                    else if (cntrl is RadioButton rdBtn &&
                            rdBtn.Checked)
                    {
                        foreach (string el in arr)
                        {
                            if (!int.TryParse(el, out int id) ||
                               id < 0)
                                continue;

                            Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                            if (item is null)
                                continue;

                            addCalc(item, 1);
                        }
                    }
                    else if (cntrl is NumericUpDown numeric)
                    {
                        foreach (string el in arr)
                        {
                            if (!int.TryParse(el, out int id) ||
                               id < 0)
                                continue;

                            Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                            if (item is null)
                                continue;

                            addCalc(item, (float)numeric.Value);
                        }
                    }
                    else if (cntrl is CheckBox checkBox &&
                             checkBox.Checked)
                    {
                        GuiHelper guiHelper = GuiHelpers.FirstOrDefault(el => el.all.Contains(checkBox));

                        float count = 1;

                        if (!(guiHelper == null))
                        {
                            NumericUpDown updwn = (NumericUpDown)guiHelper.childs.FirstOrDefault(el => el.GetType() == typeof(NumericUpDown));

                            if (!(updwn is null))
                                count = (float)updwn.Value;

                            if (guiHelper.all.Contains(checkBox))
                            {
                                // как дочерний
                                foreach (string el in arr)
                                {
                                    if (!int.TryParse(el, out int id) ||
                                       id < 0)
                                        continue;

                                    Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                    if (item is null)
                                        continue;

                                    addCalc(item, count);
                                }
                            }
                        }
                        else
                        {
                            foreach (string el in arr)
                            {
                                if (!int.TryParse(el, out int id) ||
                                   id < 0)
                                    continue;

                                Settings.Item item = Settings.settings.items.FirstOrDefault(it => it.id == id);

                                if (item is null)
                                    continue;

                                addCalc(item, count);
                            }
                        }
                    }
                }

                if (!controlIn.Enabled)
                    return;

                printCalc(controlIn);

                if (controlIn is GroupBox ||
                    controlIn is Panel)
                {
                    foreach (Control control in controlIn.Controls)
                    {
                        recurseControls(control, $"{left}  ");
                    }

                    return;
                }
            }

            foreach (Control control in Controls)
            {
                recurseControls(control, string.Empty);
            }

            #endregion

            #region проверка

            WorkTypeSub typeSub = workTypes.FirstOrDefault(el => el.button.Checked);

            if (typeSub is null)
            {
                MessageBox.Show("Вы не выбрали вид работ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            #endregion

            // Заказчик
            lstReport.Items.Add($"Наименование заказчика: {txtCustomer.Text}");

            lstReport.Items.Add("Условия при расчете:");

            lstReport.Items.Add($"Вид работ: {(typeSub.workType == WorkType.Replace? "замена" : "учимадо")}");

            #region шапка

            List<long> dicIDS = dicSummaryList.Select(el => el.Key.id).ToList();

            foreach (ActionInTop actionInTop in ActionInTop.Collection)
            {
                string line = actionInTop.outType == ActionInTop.OutType.Percent ? string.Empty : $"{actionInTop.text}: ";
                if (actionInTop.outType == ActionInTop.OutType.Bool)
                {
                    line += $"{(dicIDS.Contains(actionInTop.ids[0]) ? "есть" : "нет")}";
                }
                else if (actionInTop.outType == ActionInTop.OutType.Count)
                {
                    line += $"{(dicIDS.Contains(actionInTop.ids[0]) ? $"{dicSummaryList.FirstOrDefault(el => el.Key.id == actionInTop.ids[0]).Value.ToString()} шт." : "нет")}";
                }
                else if (actionInTop.outType == ActionInTop.OutType.Text)
                {
                    List<long> intersect = dicIDS.Intersect(actionInTop.ids).ToList();

                    if (intersect.Count > 0)
                    {
                        line += string.Join(", ", Settings.settings.items.Where(el1 => intersect.Contains(el1.id)).Select(el1 => el1.name));
                    }

                }
                else if (actionInTop.outType == ActionInTop.OutType.Percent)
                {
                    if (!dicIDS.Contains(actionInTop.ids[0]))
                    {
                        line = $"{actionInTop.text}: нет";
                    }
                    else
                    {
                        Settings.Item percentItem = Settings.settings.items.FirstOrDefault(el => el.id == actionInTop.ids[0]);
                        line = $"{actionInTop.text} ({percentItem.value}): есть";
                    }
                }
                else if (actionInTop.outType == ActionInTop.OutType.TextAndCoutn)
                {
                    List<long> intersect = dicIDS.Intersect(actionInTop.ids).ToList();

                    if (intersect.Count == 0)
                    {
                        line = $"{actionInTop.text}: нет";
                    }
                    else
                    {
                        line = $"{actionInTop.text}: есть, {dicSummaryList.Where(el => intersect.Contains(el.Key.id)).Select(el => (int)el.Value).ToList().Sum()} шт.";
                    }
                }

                lstReport.Items.Add(line);

            }

            #endregion

            lstReport.Items.Add(string.Empty);

            #region очищаем и сортируем

            dicSummaryList = dicSummaryList.
                             // фильтр по не нужным данным
                             Where(el => el.Key.seconds > 0)
                             .OrderBy(el => el.Key.id)
                             .ToDictionary(el => el.Key, el => el.Value);

            #endregion

            ///общее время в секундах на все работы
            long seconds = 0;

            long sec_mounting = 0;
            long sec_demounting = 0;

            #region монтаж изделий

            {
                var dic = dicSummaryList
                              .Where(el => el.Key.actionType == Settings.Item.ActionType.FloorInstallation)
                              //.OrderBy(el => el.Key.id)
                              .ToDictionary(el => el.Key, el => el.Value);

                if (dic.Count > 0)
                {
                    // выведем о том, что это есть
                    lstReport.Items.Add($"{Settings.Item.dicActionTypeTextes[Settings.Item.ActionType.FloorInstallation]}:");

                    foreach (Floor floor in FloorCollection.floors)
                    {
                        // вермя работя для этажа
                        long scnds = 0;

                        if (detailLog)
                            lstReport.Items.Add($"    *Этаж {floor.number}, изд. {floor.cnt}, периметр {floor.perimeter}");

                        // список настроек и кол-ва
                        foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                        {
                            // кол-во век. на этаж для выбранного действия
                            long scndsFloorAction = (long)(floor.perimeter / Settings.k * kItem.Key.seconds);

                            // кол-во секунд
                            scnds += scndsFloorAction;

                            if (detailLog)
                                lstReport.Items.Add($"      *{kItem.Key.name}. {floor.perimeter} п.м. / {Settings.k} * {kItem.Key.seconds} сек. = {scndsFloorAction} сек.");
                        }

                        // подъем на этаж
                        {
                            if (!dicIDS.Contains(Settings.settings.UchimadoFree.id) &&
                                !dicIDS.Contains(Settings.settings.ReplaceFree.id))
                                {

                                // кол-во век. на этаж для выбранного действия
                                long scndsFloorAction = (long)(floor.perimeter / Settings.k * Settings.settings.RiseToTheFloor.seconds * Math.Abs(floor.number));

                                // кол-во секунд
                                scnds += scndsFloorAction;

                                if (detailLog)
                                    lstReport.Items.Add($"      *{Settings.settings.RiseToTheFloor.name}. {floor.perimeter} п.м. / {Settings.k} * {Settings.settings.RiseToTheFloor.seconds} сек. * {Math.Abs(floor.number)} №№ = {scndsFloorAction} сек.");
                            }
                        }

                        if (detailLog)
                            lstReport.Items.Add($"    *Итого: {scnds} сек.");

                        lstReport.Items.Add($"  Для {floor.number}-го этажа, {floor.cnt} шт. {floor.perimeter} п.м. понадобится {Settings.Item.getStringTime(scnds, false)}");

                        seconds += scnds;
                        sec_mounting += scnds;
                    }

                    lstReport.Items.Add(string.Empty);
                }
            }

            #endregion

            #region монтаж москитных сеток

            {
                var dic = dicSummaryList
                              .Where(el => el.Key.actionType == Settings.Item.ActionType.InstallationOfMosquitoNets)
                              //.OrderBy(el => el.Key.id)
                              .ToDictionary(el => el.Key, el => el.Value);

                if (dic.Count > 0)
                {
                    // выведем о том, что это есть
                    lstReport.Items.Add($"{Settings.Item.dicActionTypeTextes[Settings.Item.ActionType.InstallationOfMosquitoNets]}:");

                    // список настроек и кол-ва
                    foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                    {
                        // кол-во секунд
                        long scnds = (long)(kItem.Key.seconds * kItem.Value);

                        if(detailLog)
                            lstReport.Items.Add($"    *{kItem.Key.name}. {kItem.Key.seconds} за ед. * {kItem.Value} шт. = {scnds} сек.");

                        lstReport.Items.Add($"  {kItem.Key.name}, {kItem.Value} шт. понадобится {Settings.Item.getStringTime(scnds, false)}");

                        seconds += scnds;
                        sec_mounting += scnds;
                    }

                    lstReport.Items.Add(string.Empty);
                }
            }

            #endregion
            
            #region демонтаж

            {
                var dic = dicSummaryList
                              .Where(el => el.Key.actionType == Settings.Item.ActionType.Dismantling)
                              //.OrderBy(el => el.Key.id)
                              .ToDictionary(el => el.Key, el => el.Value);

                if (dic.Count > 0)
                {
                    // выведем о том, что это есть
                    lstReport.Items.Add($"{Settings.Item.dicActionTypeTextes[Settings.Item.ActionType.Dismantling]}:");

                    // найдена группа
                    bool isGrp = false;

                    // общее время для группы
                    long grpSeconds = 0;

                    // список идентификаторов
                    List<long> ids = dic.Select(el => el.Key.id).ToList();

                    // список идентификаторов которые уже были выведены в объединениях
                    List<long> ids_in_grps = new List<long>();

                    // обработанные группы
                    List<Settings.ItemGroup> usedGrups = new List<Settings.ItemGroup>();

                    // список настроек и кол-ва
                    foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                    {
                        isGrp = false;
                        grpSeconds = 0;

                        // проверяем на обработку в группе
                        if (ids_in_grps.Contains(kItem.Key.id))
                            // уже было обработано
                            continue;

                        #region обработка объединений
                        if (Settings.idsInGroups.Contains(kItem.Key.id))
                        {
                            // эта операция учавствует в объединении

                            // поиск операции которая еще не использовалась и есть нужная операции, включая текущую
                            Settings.ItemGroup grp = Settings.itemGroups.FirstOrDefault(el => !usedGrups.Contains(el) && el.ids.Intersect(ids).Count() == el.ids.Count);
                            
                            if (!(grp is null))
                            {
                                // нйдена группа для которой есть все идентификаторы

                                // выводим название операции
                                lstReport.Items.Add($"  {grp.text}");
                                isGrp = true;

                                // суммируем общее кол-во секунд
                                grpSeconds = dic
                                             .Where(el => grp.ids.Contains(el.Key.id))
                                             .Select(el => el.Key.seconds)
                                             .Sum();

                                // добавляем в список обработанных
                                ids_in_grps.AddRange(grp.ids.ToArray());
                                
                                // добавим как обработанную группу
                                usedGrups.Add(grp);
                            }
                        } 
                        #endregion

                        // вывод в отчет
                        if (!isGrp)
                            lstReport.Items.Add($"  {kItem.Key.name}");

                        foreach (Floor floor in FloorCollection.floors)
                        {
                            // кол-во секунд = время на операцию * периметр / 4.8
                            long scnds = (long)((!isGrp ? kItem.Key.seconds : grpSeconds) * floor.perimeter / Settings.k);

                            lstReport.Items.Add($"    Для {floor.number}-го этажа, {floor.cnt} шт. {floor.perimeter} п.м. понадобится {Settings.Item.getStringTime(scnds, false)}");

                            seconds += scnds;
                            sec_demounting += scnds;
                        }
                    }

                    lstReport.Items.Add(string.Empty);
                }
            }

            #endregion

            #region прочее

            {
                var dic = dicSummaryList
                          .Where(el => el.Key.actionType == Settings.Item.ActionType.GlassClear ||
                                       el.Key.actionType == Settings.Item.ActionType.ClearWorkplace ||
                                       el.Key.actionType == Settings.Item.ActionType.PrepareWorkplace ||
                                       el.Key.actionType == Settings.Item.ActionType.Other)
                          .ToDictionary(el => el.Key, el => el.Value);

                if (dic.Count > 0)
                {
                    lstReport.Items.Add("Прочее:");

                    foreach (KeyValuePair<Settings.Item, float> kItem in dic)
                    {
                        long scnds = 0;

                        if (kItem.Key.actionType == Settings.Item.ActionType.GlassClear)
                        {
                            scnds = (long)(kItem.Key.seconds * FloorCollection.fullPerimeter / Settings.k);

                            lstReport.Items.Add($"  {kItem.Key.name} {FloorCollection.fullCnt} шт. понадобится {Settings.Item.getStringTime(scnds, false)}");
                        }
                        else if (kItem.Key.actionType == Settings.Item.ActionType.ClearWorkplace)
                        {
                            scnds = FloorCollection.fullCnt * kItem.Key.seconds;

                            lstReport.Items.Add($"  На уборку рабочего места понадобится {Settings.Item.getStringTime(scnds, false)}");
                        }
                        else if (kItem.Key.actionType == Settings.Item.ActionType.PrepareWorkplace)
                        {
                            scnds = FloorCollection.fullCnt * kItem.Key.seconds;

                            lstReport.Items.Add($"  На подготовку рабочего места понадобится {Settings.Item.getStringTime(scnds, false)}");
                        }
                        else if (kItem.Key.actionType == Settings.Item.ActionType.Other)
                        {
                            scnds = (long)(kItem.Value * kItem.Key.seconds);

                            lstReport.Items.Add($"  {kItem.Key.name} {kItem.Value} понадобится {Settings.Item.getStringTime(scnds, false)}");
                        }
                        else
                        {
                            Logger.logCalculator.Error($"Не обработанный элемент в \"Прочее\" #{kItem.Key.id}");
                            MessageBox.Show($"Не обработанный элемент в \"Прочее\" #{kItem.Key.id}", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        seconds += scnds;
                        sec_mounting += scnds;
                    }

                    lstReport.Items.Add(string.Empty);
                }
            }

            #endregion

            if (seconds == double.NaN ||
                seconds == 0)
            {
                lstReport.Items.Add($"Итого: 0ч. 0мин. 0сек.");

                return;
            }

            // Вывод итого
            lstReport.Items.Add(string.Empty);
            lstReport.Items.Add($"Итого:");
            if (sec_demounting > 0) lstReport.Items.Add($"На демонтаж понадобится {Settings.Item.getStringTime(sec_demounting, false)}");
            if (sec_mounting > 0) lstReport.Items.Add($"На монтаж понадобится {Settings.Item.getStringTime(sec_mounting, false)}");

            if (dicIDS.Contains(Settings.settings.Rain.id))
            {
                long secPercent = (long)(sec_mounting / 100.0 * Settings.settings.Rain.percent);
                lstReport.Items.Add($"На монтаж в дождливую погоду понадобится еще {Settings.Item.getStringTime(secPercent, false)}");

                sec_mounting += secPercent;
            }

            lstReport.Items.Add($"Всего на монтаж и демонтаж {FloorCollection.fullCnt} изделий {FloorCollection.fullPerimeter} м.п. понадобится:");
            lstReport.Items.Add($"{Settings.Item.getStringTime(sec_demounting + sec_mounting, false)} (24-часовой график)");
            lstReport.Items.Add($"{Settings.Item.getStringTime(sec_demounting + sec_mounting, true)} (8-часовой график)");
        }

        private void PnlInstallationConditions_EnabledChanged(object sender, EventArgs e)
        {
            lstInstallationConditions.BackColor = Color.FromKnownColor(pnlInstallationConditions.Enabled ? 
                                                                       KnownColor.Window : 
                                                                       KnownColor.Control);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            detailLog = !detailLog;
            toolStripButton1.Checked = detailLog;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // проверка выбора строки
            if (grdFloors.CurrentCell is null ||
                grdFloors.CurrentCell.RowIndex == -1)
                return;

            // считываем этаж
            Floor floor = grdFloors.Rows[grdFloors.CurrentCell.RowIndex].Tag as Floor;

            using (frmFloor frm = new frmFloor(floor))
            {
                while (frm.ShowDialog() == DialogResult.OK)
                {
                    #region проверки

                    Floor finded = FloorCollection.floors.FirstOrDefault(el => el != floor && el.number == (int)frm.numNumber.Value);

                    if (!(finded is null))
                        continue;

                    if (!int.TryParse(frm.txtPerimeter.Text.Replace(".", ","), out int perimeter) ||
                        perimeter <= 0)
                        continue;

                    #endregion

                    // заменяем
                    floor.number = (int)frm.numNumber.Value;
                    floor.cnt = (int)frm.numCnt.Value;
                    floor.perimeter = perimeter;

                    FloorCollection.refresh();

                    break;
                }
            }
        }

        private void BtnSaveReport_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.FileName = "Отчет.txt";
                dlg.Filter = "Текстовые документы|*.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                    fileName = dlg.FileName;
                else
                    return;
            }

            try
            {
                using (StreamWriter wr = new StreamWriter(fileName,
                                                          false,
                                                          Encoding.GetEncoding(1251)))
                {
                    for (int i = 0; i < lstReport.Items.Count; i++)
                        wr.WriteLine(lstReport.Items[i]);
                    wr.Flush();
                }
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex, "Ошибка сохранения отчета");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            #region преспросим

            if (MessageBox.Show("Вы уверены что хотите очистить данные?",
                                    "Внимание", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return; 

            #endregion

            void clear(Control control)
            {
                if (control is RadioButton rdBtn) rdBtn.Checked = false;
                if (control is CheckBox chkBox) chkBox.Checked = false;

                if (control.Controls is null ||
                    control.Controls.Count == 0)
                    return;

                foreach (Control controlSub in control.Controls)
                    clear(controlSub);
            }

            foreach (Control control in Controls)
                clear(control);

            FloorCollection.Clear();

            txtCustomer.Text = string.Empty;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
