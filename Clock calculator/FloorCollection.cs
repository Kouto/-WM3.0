using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_calculator
{
    /// <summary>
    /// Список всех этажей
    /// </summary>
    static class FloorCollection
    {
        /// <summary>
        /// Событие обновления списка этажей
        /// </summary>
        public static event EventHandler evRefresh;

        /// <summary>
        /// Список этажей
        /// </summary>
        public static List<Floor> floors = new List<Floor>();

        public static float fullPerimeter { get; private set; } = 0;

        public static int fullCnt { get; private set; } = 0;

        public static bool addFloor(Floor floor)
        {
            #region проверки

            #region существование такого этажа

            if (!(floors.FirstOrDefault(el => el.number == floor.number) is null))
            {
                // добавим в лог
                Logger.logCalculator.Error($"Этаж с номером {floor.number} уже существует");

                MessageBox.Show($"Этаж с номером {floor.number} уже существует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            #endregion

            #region корректности периметра

            if (floor.perimeter <= 0)
            {
                // добавим в лог
                Logger.logCalculator.Error($"Периметр этажа = {floor.perimeter}, что является ошибкой");

                MessageBox.Show($"Периметр этажа = {floor.perimeter}, что является ошибкой", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            #endregion

            #endregion

            // добавляем этаж
            floors.Add(floor);

            // сортируем
            floors = floors.OrderBy(el => el.number).ToList();

            refresh();

            return true;
        }

        public static bool addFloor(int number, int cnt, float perimeter) => addFloor(new Floor(number, cnt, perimeter));

        public static bool delFloor(Floor floor)
        {
            if (!floors.Contains(floor))
                return false;

            floors.Remove(floor);

            refresh();

            return true;
        }

        public static void refresh()
        {
            fullCnt = floors.Select(el => el.cnt).Sum();
            fullPerimeter = floors.Select(el => el.perimeter).Sum();

            try
            {
                evRefresh?.Invoke(null, null);
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex);
            }
        }

        public static void Clear()
        {
            floors.Clear();

            refresh();
        }
    }
}
