using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_calculator
{
    class WorkTypeSub
    {
        /// <summary>
        /// Тип выбранной работы
        /// </summary>
        public readonly WorkType workType;
        /// <summary>
        /// Должн быть что-то выбрано
        /// </summary>
        public readonly bool needSelectValue;
        /// <summary>
        /// Варианты выбора
        /// </summary>
        public readonly List<long> actionIDS;

        /// <summary>
        /// Кнопка, к которой привязан
        /// </summary>
        public readonly RadioButton button;

        public readonly string text;

        public WorkTypeSub(WorkType workType, RadioButton button, string text) : this(workType, button, text, false, new List<long>()) { }

        public WorkTypeSub(WorkType workType, RadioButton button, string text, List<long> actionIDS)
        {
            this.workType = workType;
            this.button = button;
            this.needSelectValue = actionIDS.Count > 0;
            this.actionIDS = actionIDS;
            this.text = text;
        }

        public WorkTypeSub(WorkType workType, RadioButton button, string text, bool needSelectValue, List<long> actionIDS)
        {
            this.workType = workType;
            this.button = button;
            this.needSelectValue = needSelectValue;
            this.actionIDS = actionIDS;
            this.text = text;
        }
    }
}
