using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll
{
    public class Calc : MarshalByRefObject
    {
        public double calculate(double a, double b)
        {
            return a + b;
        }
    }
}
