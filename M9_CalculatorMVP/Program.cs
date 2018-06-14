using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using M9_CalculatorMVP.Forms;
using M9_CalculatorMVP.Presenters;

namespace M9_CalculatorMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CalcForm calcForm = new CalcForm();
            CalcFormPresenter calcFormPresenter = new CalcFormPresenter(calcForm);

            Application.Run(calcForm);
        }
    }
}
