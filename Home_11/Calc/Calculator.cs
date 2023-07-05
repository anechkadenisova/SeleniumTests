using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Calc
{
    public class Calculator
    {
        public  double Add(double x, double y) => x + y;
        public  double Multiply(double x, double y) => x * y;
        public double Sub(double x, double y) => x - y;
        public double Div(double x, double y) => x / y;
    }
}
 