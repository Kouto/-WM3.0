using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_calculator
{
    class WorkTypeAtt: Attribute
    {
        internal readonly string text;

        internal WorkTypeAtt(string text)
        {
            this.text = text;
        }
    }
}
