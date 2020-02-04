using System.Collections.Generic;

namespace Clock_calculator
{
    internal partial class Settings
    {
        /// <summary>
        /// Группы настроек
        /// </summary>
        internal partial class ItemGroup
        {

            /// <summary>
            /// Объединяемые идентификаторы
            /// </summary>
            internal readonly List<long> ids;
            
            /// <summary>
            /// Выводимый текст
            /// </summary>
            internal readonly string text;

            /// <summary>
            /// Конструктор
            /// </summary>
            /// <param name="text">Текст</param>
            /// <param name="ids">Спикок идентификаторов</param>
            internal ItemGroup(string text, List<long> ids)
            {
                this.text = text;
                this.ids = ids;
            }
        }
    }
}

