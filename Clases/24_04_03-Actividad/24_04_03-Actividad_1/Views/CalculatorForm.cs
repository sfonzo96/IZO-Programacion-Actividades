using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _24_04_03_Actividad_1.Models;

namespace _24_04_03_Actividad_1.Views
{
    public partial class CalculatorForm : Form
    {
        public User _CurrentUser;
        public CalculatorForm(User current)
        {
            InitializeComponent();
            this._CurrentUser = current;
            this.LoadUsername();
        }

        private void LoadUsername()
        {
            NameLbl.Text = this._CurrentUser.Name;
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(FirstValueTxt.Text.Trim());
                double secondNumber = Convert.ToDouble(SecondValueTxt.Text.Trim());

                if (secondNumber == 0)
                {
                    MessageBox.Show("No se puede dividir por cero!");
                    return;
                }

                ResultLbl.Text = Convert.ToString(firstNumber / secondNumber);
            }
            catch (FormatException) {
                MessageBox.Show("Alguno de los valores is invalido");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(FirstValueTxt.Text.Trim());
                double secondNumber = Convert.ToDouble(SecondValueTxt.Text.Trim());

                ResultLbl.Text = Convert.ToString(firstNumber + secondNumber);
            }
            catch (FormatException)
            {
                MessageBox.Show("Alguno de los valores is invalido");
            }
        }

        private void SubsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(FirstValueTxt.Text.Trim());
                double secondNumber = Convert.ToDouble(SecondValueTxt.Text.Trim());

                ResultLbl.Text = Convert.ToString(firstNumber - secondNumber);
            }
            catch (FormatException)
            {
                MessageBox.Show("Alguno de los valores is invalido");
            }
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(FirstValueTxt.Text.Trim());
                double secondNumber = Convert.ToDouble(SecondValueTxt.Text.Trim());

                ResultLbl.Text = Convert.ToString(firstNumber * secondNumber);
            }
            catch (FormatException)
            {
                MessageBox.Show("Alguno de los valores is invalido");
            }
        }
    }
}
