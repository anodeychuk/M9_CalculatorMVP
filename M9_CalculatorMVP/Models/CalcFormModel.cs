using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using M9_CalculatorMVP.Forms;

namespace M9_CalculatorMVP.Models
{
    public class CalcFormModel
    {
        public double Calc(double a, double b, CalcOperation operation)
        {
            double result = 0;
            switch (operation)
            {
                case CalcOperation.Addition:
                    result = a + b;
                    break;
                case CalcOperation.Difference:
                    result = a - b;
                    break;
                case CalcOperation.Multiplication:
                    result = a * b;
                    break;
                case CalcOperation.Division:
                    if ((a == 0) && (b == 0)) throw new ArithmeticException();
                    if (b == 0) throw new DivideByZeroException();
                    result = a / b;
                    break;
            }
            return result;
        }

        public bool InputCheck(char c)
        {
            Regex regex = new Regex("[-0-9.]");
            return regex.IsMatch(c.ToString());
        }
    }
}
