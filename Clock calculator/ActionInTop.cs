using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_calculator
{
    /// <summary>
    /// действие в шапке
    /// </summary>
    class ActionInTop
    {
        internal enum OutType
        {
            Bool,
            Count,
            Text,
            Percent,
            TextAndCoutn,
        }

        internal readonly List<long> ids;
        internal readonly string text;
        internal OutType outType;

        internal ActionInTop(OutType outType, long id) : this(Settings.settings.items.FirstOrDefault(el => el.id == id).name, outType, new List<long>() { id }) { }

        internal ActionInTop(string text, OutType outType, long id) : this(text, outType, new List<long>() { id }) { }

        internal ActionInTop(string text, OutType outType, List<long> ids)
        {
            this.text = text;
            this.outType = outType;
            this.ids = ids;
        }

        /// <summary>
        /// Список параметров выводящихся в шапке
        /// </summary>
        static internal List<ActionInTop> Collection = new List<ActionInTop>()
        {
            new ActionInTop("Монтажный шов", OutType.Text, new List<long>() { 200,201,202,203,300,301,302,303,304,305,306 }),
            new ActionInTop(OutType.Bool, 500),
            new ActionInTop(OutType.Bool, 501),
            new ActionInTop(OutType.Bool, 502),
            new ActionInTop(OutType.Bool, 503),
            new ActionInTop(OutType.Bool, 504),
            new ActionInTop(OutType.Bool, 505),
            new ActionInTop(OutType.Count, 506),
            new ActionInTop("Вид крепления", OutType.Text, new List<long> () { 507, 508 }),
            new ActionInTop("Способ крепления", OutType.Text, new List<long> () { 509, 510 }),
            new ActionInTop(OutType.Count, 511),
            new ActionInTop(OutType.Count, 512),
            new ActionInTop(OutType.Count, 513),
            new ActionInTop("Москитная стека", OutType.TextAndCoutn, new List<long> () { 400, 401, 402, 403 }),
            new ActionInTop(OutType.Bool, 514),
            new ActionInTop(OutType.Bool, 515),
            new ActionInTop(OutType.Bool, 516),
            new ActionInTop(OutType.Percent, 517),
        };


    }
}
