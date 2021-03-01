using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.ViewModels;


namespace SimpleCalculatorView
{
    public partial class Form1View : Form
    {
        private readonly OperationViewModel viewModel = new OperationViewModel();
        public Form1View()
        {
            InitializeComponent();

            txtBoxNo1.DataBindings.Add("Text", viewModel.NewOperation, "number1");
            txtBoxNo2.DataBindings.Add("Text", viewModel.NewOperation, "number2");
            txtBoxResult.DataBindings.Add("Text", viewModel.NewOperation, "result");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            viewModel.NewOperation.Operation = '+';
            viewModel.GetResult();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            viewModel.NewOperation.Operation = '-';
            viewModel.GetResult();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            viewModel.NewOperation.Operation = '*';
            viewModel.GetResult();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            viewModel.NewOperation.Operation = '/';
            viewModel.GetResult();
        }


        //wpisywanie tylko liczb i jednego przecinka do textboxów
        private void txtBoxNo1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxNo2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
