using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M9_CalculatorMVP.Forms;
using M9_CalculatorMVP.Views;
using M9_CalculatorMVP.Models;

namespace M9_CalculatorMVP.Presenters
{
    public class CalcFormPresenter
    {
        private ICalcFormView view;
        private CalcFormModel model;

        public CalcFormPresenter(ICalcFormView view)
        {
            this.view = view;
            this.model = new CalcFormModel();
            this.view.Calc += new Action<CalcOperation>(this.Calc);
            this.view.InputCheck += new EventHandler<KeyPressEventArgs>(this.InputCheck);
        }

        private void Calc(CalcOperation operation)
        {
            try
            {
                this.view.SetResult(this.model.Calc(this.view.GetFirstArg(), this.view.GetSecondArg(), operation));
            }
            catch (DivideByZeroException)
            {
                this.view.ShowMessege("Sorry, but result of the operation can not be calculated: Division by zero");
            }
            catch (Exception)
            {
                this.view.ShowMessege("Sorry, but result of the operation can not be calculated");
            }
        }

        private void InputCheck(object sender, KeyPressEventArgs e) {
            if (!this.model.InputCheck(e.KeyChar)) 
                e.Handled = true;
        }
    }
}
