using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_calculator
{
    public partial class frmSettings : Form
    {
        /// <summary>
        /// Новый экземпляр настроек
        /// </summary>
        readonly Settings settings = new Settings();

        public frmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            #region добавляем настройки

            foreach (Settings.Item item in settings.items)
            {
                grdSettings.Rows.Add(item.name, item.value, item.value);
                grdSettings.Rows[grdSettings.Rows.Count - 1].Tag = item;
            }

            #endregion

            txtPass.Text = Password.getKey();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // завершаем изменения
            grdSettings.EndEdit();

            #region проверка пароля

            if (new frmLogin().ShowDialog() != DialogResult.OK)
                return; 

            #endregion

            #region проверка

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Введите пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            foreach (DataGridViewRow row in grdSettings.Rows)
            {
                Settings.Item item = (Settings.Item)row.Tag;

                if (item.itemType == Settings.Item.ItemType.Time)
                {
                    string value = row.Cells[2].Value.ToString();

                    if (!TimeSpan.TryParse(value, out TimeSpan time) ||
                        time.TotalMilliseconds < 0)
                    {
                        Logger.logCalculator.Error($"Ошибка преобразования {value} в TimeSpan");

                        MessageBox.Show($"Ошибка преобразования {value} в TimeSpan", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    item.time = time;
                }

                if (item.itemType == Settings.Item.ItemType.Percent)
                {
                    string value = row.Cells[2].Value.ToString().Replace(".", ",");

                    if (!float.TryParse(value, out float percent) ||
                        percent < 0 ||
                        percent > 1000)
                    {
                        Logger.logCalculator.Error($"Ошибка преобразования {value} в TimeSpan");

                        MessageBox.Show($"Ошибка преобразования {value} в TimeSpan", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    item.percent = percent;
                }

            }

            #endregion

            #region изменяем настройки

            string json = Settings.getJSON(settings.items);

            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    File.WriteAllText(Settings.fileName,
                                      json,
                                      Encoding.GetEncoding(1251));

                    Settings.refresh();

                    Logger.logCalculator.Info("Изменение настроек");

                    MessageBox.Show("Настройки изменены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Password.saveKey(txtPass.Text);

                    Close();
                }
                catch (Exception ex)
                {
                    Logger.logCalculator.Error(ex, $"Ошибка записи в файл {Settings.fileName}");

                    MessageBox.Show($"Ошибка записи в файл {Settings.fileName}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            #endregion
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
