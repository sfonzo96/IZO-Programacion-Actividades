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
    public partial class ConcatForm : Form
    {
        public User _CurrentUser;

        public ConcatForm(User current)
        {
            InitializeComponent();
            this._CurrentUser = current;
            NameLbl.Text = this._CurrentUser.Name;
            FirstNameTxt.Text = this._CurrentUser.Name;

        }

        private void ConcatBtn_Click(object sender, EventArgs e)
        {
            String lastName = LastNameTxt.Text;

            FullNameLbl.Text = $"{lastName} {this._CurrentUser.Name}";
        }
    }
}
