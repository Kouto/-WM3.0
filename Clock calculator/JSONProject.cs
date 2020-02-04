using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_calculator
{
    class JSONProject_paramDouble
    {
        public bool avaible { get; set; } = false;
        public int count { get; set; } = 0;
    }

    class JSONProject_workType
    {
        public long GTypeID { get; set; } = 0;
        public string GTypeName { get; set; } = string.Empty;
        public long SubTypeID { get; set; } = 0;
        public string SubTypeName { get; set; } = string.Empty;
        public long materialID { get; set; } = 0;
        public string materialName { get; set; } = string.Empty;
    }

    /// <summary>
    /// Класс проекта (файла)
    /// </summary>
    class JSONProject
    {
        /// <summary>
        /// Заказчик
        /// </summary>
        public string customer { get; set; } = string.Empty;

        /// <summary>
        /// Список этажей
        /// </summary>
        public List<Floor> floors { get; set; } = new List<Floor>();

        public JSONProject_paramDouble mosq_door { get; set; } = new JSONProject_paramDouble();

        public JSONProject_paramDouble mosq_border { get; set; } = new JSONProject_paramDouble();

        public JSONProject_paramDouble mosq_slide { get; set; } = new JSONProject_paramDouble();

        public JSONProject_paramDouble mosq_pliss { get; set; } = new JSONProject_paramDouble();

        public JSONProject_workType workType { get; set; } = new JSONProject_workType();

        public JSONProject()
        {
            
        }
    }
}
