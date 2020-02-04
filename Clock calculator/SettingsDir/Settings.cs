using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_calculator
{
    internal partial class Settings
    {

        /// <summary>
        /// Коэффициент для формулы
        /// </summary>
        static readonly internal float k = 4.8f;

        private static Settings _settings = null;

        /// <summary>
        /// Список групп для объединения
        /// </summary>
        static internal List<ItemGroup> itemGroups = new List<ItemGroup>()
        {
            new ItemGroup("2-я нитка в деревянном доме (снять створки + срезать направляющие рельсы)", new List<long>() { 603, 604 }),
            new ItemGroup("2-я нитка в бетонном доме (снять створки + срезать направляющие рельсы", new List<long>() { 606, 607 }),
        };


        private static List<long> _idsInGroups = new List<long>();

        /// <summary>
        /// Список всех идентификаторов учавствующих в группах
        /// </summary>
        internal static List<long> idsInGroups
        {
            get
            {
                if (_idsInGroups.Count > 0)
                    return _idsInGroups;

                _idsInGroups = // объединяем все идентифкаторы в одну строку
                               string.Join(",",
                               itemGroups
                               .Select(el => string.Join(",", el.ids)))
                               // разделяем данные на элементы
                               .Split(',')
                               // удялаем пустышки (на всякий случай)
                               .Where(el => !string.IsNullOrEmpty(el))
                               // преобразовывем string to long
                               .Select(el => long.Parse(el))
                               // преобразовываем в список
                               .ToList();

                return _idsInGroups;
            }
        }

        internal static void refresh()
        {
            _settings = new Settings();
        }

        internal static Settings settings
        {
            get
            {
                if (_settings is null)
                    refresh();

                return _settings;
            }
        }

        #region список настроек

        public readonly Item RiseToTheFloor = new Item(100, Item.ActionType.FloorInstallation, "Подъем на этаж", new TimeSpan(0, 2, 30));

        public readonly Item UchimadoSiliconInner = new Item(200, Item.ActionType.FloorInstallation, "Учимадо - силикон внутренний", new TimeSpan(2, 0, 0), true);
        public readonly Item UchimadoSiliconOuter = new Item(201, Item.ActionType.FloorInstallation, "Учимадо - силикон наружный", new TimeSpan(2, 0, 0), true);
        public readonly Item UchimadoPSUL = new Item(202, Item.ActionType.FloorInstallation, "Учимадо - ПСУЛ illmond", new TimeSpan(0, 40, 0), true);
        public readonly Item UchimadoFree = new Item(203, Item.ActionType.FloorInstallation, "Учимадо - без монтажа", new TimeSpan(0, 15, 0), true);
        public readonly Item UchimadoSilicon = new Item(204, Item.ActionType.FloorInstallation, "Учимадо - силикон", new TimeSpan(2, 0, 0), true);

        public readonly Item ReplaceFoam = new Item(300, Item.ActionType.FloorInstallation, "Замена - монтажная пена", new TimeSpan(1, 0, 0), true);
        public readonly Item ReplaceSiliconInner = new Item(301, Item.ActionType.FloorInstallation, "Замена - силикон внутренний", new TimeSpan(1, 30, 0), true);
        public readonly Item ReplaceSiliconOuter = new Item(302, Item.ActionType.FloorInstallation, "Замена - силикон наружный", new TimeSpan(1, 30, 0), true);
        public readonly Item ReplaceSiliconRobiInner = new Item(303, Item.ActionType.FloorInstallation, "Замена - робибанд внутренний", new TimeSpan(1, 0, 0), true);
        public readonly Item ReplaceSiliconRobiЩгеук = new Item(304, Item.ActionType.FloorInstallation, "Замена - робибанд наружный", new TimeSpan(2, 0, 0), true);
        public readonly Item ReplacePSUL = new Item(305, Item.ActionType.FloorInstallation, "Замена - ПСУЛ illmond", new TimeSpan(0, 40, 0), true);
        public readonly Item ReplaceFree = new Item(306, Item.ActionType.FloorInstallation, "Замена - без монтажа", new TimeSpan(0, 15, 0), true);

        public readonly Item MosqDoor = new Item(400, Item.ActionType.InstallationOfMosquitoNets, "Дверная москитная сетка", new TimeSpan(0, 30, 0));
        public readonly Item MosqSlide = new Item(401, Item.ActionType.InstallationOfMosquitoNets, "Слайд москитная сетка", new TimeSpan(0, 15, 0));
        public readonly Item MosqBorder = new Item(402, Item.ActionType.InstallationOfMosquitoNets, "Рамочная москитная сетка", new TimeSpan(0, 10, 0));
        public readonly Item MosqPliss = new Item(403, Item.ActionType.InstallationOfMosquitoNets, "Плиссе москитная сетка", new TimeSpan(2, 0, 0));

        public readonly Item PVHInner = new Item(500, Item.ActionType.FloorInstallation, "Внутренний ПВХ уголок", new TimeSpan(0, 30, 0), true);
        public readonly Item PVHOuter = new Item(501, Item.ActionType.FloorInstallation, "Наружный ПВХ уголок", new TimeSpan(0, 30, 0), true);
        public readonly Item CashOutInner = new Item(502, Item.ActionType.FloorInstallation, "Внутренняя обналичка", new TimeSpan(2, 0, 0), true);
        public readonly Item CashOutOuter = new Item(503, Item.ActionType.FloorInstallation, "Внешняя обналичка", new TimeSpan(2, 0, 0), true);
        public readonly Item Prof3028 = new Item(504, Item.ActionType.FloorInstallation, "Профиль 3028", new TimeSpan(0, 20, 0), true);
        public readonly Item Otliv = new Item(505, Item.ActionType.FloorInstallation, "Отлив", new TimeSpan(1, 0, 0), true);
        public readonly Item Primat = new Item(506, Item.ActionType.Other, "Примат", new TimeSpan(2, 0, 0));
        public readonly Item AnkerPlate = new Item(507, Item.ActionType.FloorInstallation, "Анкерная пластина", new TimeSpan(0, 10, 0), true);
        public readonly Item Skvoznoy = new Item(508, Item.ActionType.FloorInstallation, "Сквозной монтаж", new TimeSpan(0, 10, 0), true);
        public readonly Item Anker = new Item(509, Item.ActionType.FloorInstallation, "Анкер", new TimeSpan(0, 20, 0), true);
        public readonly Item Screw = new Item(510, Item.ActionType.FloorInstallation, "Саморез", new TimeSpan(0, 10, 0), true);
        public readonly Item JoinnerProf2 = new Item(511, Item.ActionType.Other, "Соед. профиль 2 мм", new TimeSpan(0, 20, 0));
        public readonly Item JoinnerProf20 = new Item(512, Item.ActionType.Other, "Соед. профиль 20 мм", new TimeSpan(0, 20, 0));
        public readonly Item Pilyastra = new Item(513, Item.ActionType.Other, "Пилястра", new TimeSpan(0, 30, 0));
        public readonly Item WorkplacePreparation = new Item(514, Item.ActionType.PrepareWorkplace, "Подготовка рабочего места", new TimeSpan(0, 20, 0));
        public readonly Item WorkplacClear = new Item(515, Item.ActionType.PrepareWorkplace, "Уборка рабочего места", new TimeSpan(0, 20, 0));
        public readonly Item ClearGlass = new Item(516, Item.ActionType.GlassClear, "Мытье профиля, стекол", new TimeSpan(0, 20, 0), true);
        public readonly Item Rain = new Item(517, Item.ActionType.Rain, "Вероятность дождя", 20.0f, true);

        public readonly Item DismantlingWood1 = new Item(600, Item.ActionType.Dismantling, "Демонтаж - 1-я нитка в деревянном доме", new TimeSpan(2, 0, 0));
        public readonly Item DismantlingBeton1 = new Item(601, Item.ActionType.Dismantling, "Демонтаж - 1-я нитка в бетонном доме", new TimeSpan(2, 0, 0));
        public readonly Item DismantlingWood2 = new Item(602, Item.ActionType.Dismantling, "Демонтаж - 2-я нитка в деревянном доме", new TimeSpan(0, 0, 0));
        public readonly Item DismantlingWoodOnlyStvorki = new Item(603, Item.ActionType.Dismantling, "Деревянный - снять створки", new TimeSpan(0, 10, 0));
        public readonly Item DismantlingWoodRemoveRelsi = new Item(604, Item.ActionType.Dismantling, "Деревянный - срезать направляющие рельсы", new TimeSpan(1, 0, 0));
        public readonly Item DismantlingBeton2 = new Item(605, Item.ActionType.Dismantling, "Демонтаж - 2-я нитка в бетонном доме", new TimeSpan(0, 0, 0));
        public readonly Item DismantlingBetonOnlyStvorki = new Item(606, Item.ActionType.Dismantling, "Бетонный - снять створки", new TimeSpan(0, 10, 0));
        public readonly Item DismantlingBetonRemoveRelsi = new Item(607, Item.ActionType.Dismantling, "Бетонный - cнять направляющие рельсы", new TimeSpan(0, 30, 0)); 

        #endregion

        public readonly List<Item> items;

        public static string fileName = $"{Directory.GetCurrentDirectory()}\\set.json";

        public Settings()
        {
            items = new List<Item>()
            {
                RiseToTheFloor,

                UchimadoSiliconInner,
                UchimadoSiliconOuter,
                UchimadoPSUL,
                UchimadoFree,
                UchimadoSilicon,

                ReplaceFoam,
                ReplaceSiliconInner,
                ReplaceSiliconOuter,
                ReplaceSiliconRobiInner,
                ReplaceSiliconRobiЩгеук,
                ReplacePSUL,
                ReplaceFree,


                MosqDoor,
                MosqSlide,
                MosqBorder,
                MosqPliss,

                PVHInner,
                PVHOuter,
                CashOutInner,
                CashOutOuter,

                Prof3028,
                Otliv,
                Primat,
                AnkerPlate,
                Skvoznoy,
                Anker,
                Screw,
                JoinnerProf2,
                JoinnerProf20,
                Pilyastra,
                WorkplacePreparation,
                WorkplacClear,
                ClearGlass,
                Rain,

                DismantlingWood1,
                DismantlingBeton1,
                DismantlingWood2,
                DismantlingWoodOnlyStvorki,
                DismantlingWoodRemoveRelsi,
                DismantlingBeton2,
                DismantlingBetonOnlyStvorki,
                DismantlingBetonRemoveRelsi,
            };

            if (File.Exists(fileName))
            {
                try
                {
                    string json = File.ReadAllText(fileName, Encoding.GetEncoding(1251));

                    List<Item> list = getList(Base64Decode(json));

                    foreach (Item item in items)
                    {
                        Item newIt = list.FirstOrDefault(el => el.id == item.id);

                        if (newIt is null)
                        {
                            // что-то пошло не так
                            Logger.logCalculator.Error($"Не найдена настройка для \"{item.name}\"");

                            continue;
                        }

                        item.time = newIt.time;
                        item.percent = newIt.percent;

                    }
                }
                catch (Exception ex)
                {
                    Logger.logCalculator.Error(ex, "Ошибка чтения файла настроек");

                    MessageBox.Show("Ошибка чтения файла настроек", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Шифрование строки в BASE64
        /// </summary>
        /// <param name="plainText">исходная строка</param>
        /// <returns>зашифрованная строка</returns>
        internal static string Base64Encode(string plainText)
        {
            Debug.Print(plainText);

            var plainTextBytes = Encoding.GetEncoding(1251).GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Дешифрование строки
        /// </summary>
        /// <param name="base64EncodedData">Строка в BASE64</param>
        /// <returns>нормальная строка</returns>
        internal static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);

            string ret = System.Text.Encoding.UTF8.GetString(base64EncodedBytes); ;

            Debug.Print(ret);

            return ret;
        }

        /// <summary>
        /// Получить JSON строку из списка настроек
        /// </summary>
        /// <param name="list">список настроек</param>
        /// <returns>строка</returns>
        public static string getJSON(List<Item> list)
        {
            try
            {
                return Base64Encode(Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented));
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex, "Ошибка преобразования");

                MessageBox.Show("Ошибка преобразования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        /// <summary>
        /// получить список настроек из JSON строки
        /// </summary>
        /// <param name="json">строка</param>
        /// <returns>список настроек</returns>
        public static List<Item> getList(string json)
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Item>>(json);
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex, "Ошибка преобразования");

                MessageBox.Show("Ошибка преобразования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<Item>();
            }
        }
    }
}

