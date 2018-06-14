using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M9_CalculatorMVP.Forms;

namespace M9_CalculatorMVP.Views
{
    public interface ICalcFormView
    {
        double GetFirstArg();
        double GetSecondArg();
        void SetResult(double result);
        void ShowMessege(string messege);
        event Action<CalcOperation> Calc;
        event EventHandler<KeyPressEventArgs> InputCheck;
    }
}
