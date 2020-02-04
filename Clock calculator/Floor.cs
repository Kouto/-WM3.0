using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_calculator
{
    /// <summary>
    /// Класс описывающий этаж
    /// </summary>
    class Floor
    {
        /// <summary>
        /// Номер этажа
        /// </summary>
        public int number;

        /// <summary>
        /// кол-во
        /// </summary>
        public int cnt;

        /// <summary>
        /// периметр
        /// </summary>
        public float perimeter;

        /// <summary>
        /// Пустой конструктор класса для JSON
        /// </summary>
        public Floor() { }

        public Floor(int number, int cnt, float perimeter)
        {
            this.number = number;
            this.cnt = cnt;
            this.perimeter = perimeter;
        }
    }
}
