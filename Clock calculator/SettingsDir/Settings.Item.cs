using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Clock_calculator
{
    internal partial class Settings
    {
        /// <summary>
        /// Элемент настройки
        /// </summary>
        public class Item
        {
            /// <summary>
            /// Тип настройки
            /// </summary>
            public enum ItemType
            {
                Time,
                Percent,
            }

            public enum ActionType
            {
                /// <summary>
                /// Установка сеток
                /// </summary>
                FloorInstallation,
                /// <summary>
                /// Монтаж этажа
                /// </summary>
                InstallationOfMosquitoNets,
                /// <summary>
                /// Подготовка к работе
                /// </summary>
                PrepareWorkplace,
                /// <summary>
                /// Демонтаж
                /// </summary>
                Dismantling,
                /// <summary>
                /// Мойка
                /// </summary>
                GlassClear,
                /// <summary>
                /// Доджь
                /// </summary>
                Rain,
                /// <summary>
                /// Уборка помещения
                /// </summary>
                ClearWorkplace,
                /// <summary>
                /// Прочее
                /// </summary>
                Other,
            }

            static internal readonly Dictionary<ActionType, string> dicActionTypeTextes = new Dictionary<ActionType, string>()
            {
                { ActionType.PrepareWorkplace, "Подготовка" },
                { ActionType.Dismantling, "Демонтаж" },
                { ActionType.InstallationOfMosquitoNets, "Монтаж сеток" },
                { ActionType.FloorInstallation, "Монтаж изделий" },
                { ActionType.GlassClear, "Мойка" },
                { ActionType.ClearWorkplace, "Уборка помещения" },
                { ActionType.Rain, "Вероятность дождя" },
            };

            /// <summary>
            /// Идентификатор
            /// </summary>
            public long id;

            public ActionType actionType;

            /// <summary>
            /// название настройки
            /// </summary>
            public string name;
            /// <summary>
            /// тип настройки
            /// </summary>
            public ItemType itemType;
            /// <summary>
            /// Время выполнения
            /// </summary>
            public TimeSpan time = new TimeSpan(0, 0, 0);
            /// <summary>
            /// Надбавка
            /// </summary>
            public float percent = 0;
            /// <summary>
            /// признак того, что настройка идет только кол-во всегда = 1
            /// </summary>
            public bool onlyOne = false;

            [JsonIgnore]
            internal string value
            {
                get
                {
                    if (itemType == ItemType.Time)
                        return $"{time.Hours}:{time.Minutes}:{time.Seconds}";

                    return $"{percent}";
                }
            }

            [JsonIgnore]
            internal long seconds => time.Hours * 60 * 60 + time.Minutes * 60 + time.Seconds;

            internal Item(long id, ActionType actionType, string name, TimeSpan time, bool onlyOne = false)
            {
                this.itemType = ItemType.Time;
                this.name = name;
                this.time = time;
                this.id = id;
                this.actionType = actionType;
                this.onlyOne = onlyOne;
            }

            internal Item(long id, ActionType actionType, string name, float percent, bool onlyOne = false)
            {
                this.itemType = ItemType.Percent;
                this.name = name;
                this.percent = percent;
                this.id = id;
                this.actionType = actionType;
                this.onlyOne = onlyOne;
            }

            /// <summary>
            /// Пустой конструктор для JSON
            /// </summary>
            internal Item() { }

            private static readonly long secInWorkDay = 8 * 60 * 60;

            /// <summary>
            /// Преобразование секунд в дату
            /// </summary>
            /// <param name="seconds">секунды</param>
            /// <param name="h8">8-ми часовой день</param>
            /// <returns>Строка с временем и датой</returns>
            internal static string getStringTime(long seconds, bool h8 = true)
            {
                if (!h8)
                {
                    TimeSpan result = TimeSpan.FromSeconds(seconds);

                    return $"{(result.Days > 0 ? $"{result.Days} дн. " : string.Empty)}" +
                           $"{result.Hours} ч. " +
                           $"{result.Minutes} мин. " +
                           $"{result.Seconds} сек. ";
                }

                long d = seconds / secInWorkDay;
                if (d > 0) seconds -= d * secInWorkDay;
                long h = seconds / (60 * 60);
                if (h > 0) seconds -= h * 60 * 60;
                long m = seconds / 60;
                if (m > 0) seconds -= m * 60;
                long sec = seconds;

                return $"{(d > 0 ? $"{d} дн. " :  string.Empty)}" +
                       $"{h} ч. " +
                       $"{m} мин. " +
                       $"{sec} сек.";
            }
        }
    }
}

