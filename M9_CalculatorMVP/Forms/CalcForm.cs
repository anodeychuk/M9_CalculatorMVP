using System;
using System.Windows.Forms;

using M9_CalculatorMVP.Views;

namespace M9_CalculatorMVP.Forms
{
    public enum CalcOperation
    {
        Addition, Difference, Multiplication, Division
    }

    public partial class CalcForm : Form, ICalcFormView
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        public event Action<CalcOperation> Calc;
        public event EventHandler<KeyPressEventArgs> InputCheck;

        public double GetFirstArg()
        {
            return Convert.ToDouble(FirstArg.Text);
        }

        public double GetSecondArg()
        {
            return Convert.ToDouble(SecondArg.Text);
        }

        public void SetResult(double result)
        {
            Result.Text = result.ToString();
        }

        public void ShowMessege(string messege)
        {
            MessageBox.Show(messege);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FirstArg_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.Invoke(sender, e);
        }

        private void SecondArg_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.Invoke(sender, e);
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            Calc.Invoke(CalcOperation.Addition);
        }

        private void DifferenceBtn_Click(object sender, EventArgs e)
        {
            Calc.Invoke(CalcOperation.Difference);
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            Calc.Invoke(CalcOperation.Multiplication);
        }

        private void DevisionBtn_Click(object sender, EventArgs e)
        {
            Calc.Invoke(CalcOperation.Division);
        }
    }
}
