using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduel1_1
{
    public class Variable
    {
        public int a = 1;
        public int b = 2;
        public void Change()
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
