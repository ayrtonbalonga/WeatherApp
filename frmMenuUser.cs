using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weatherapp
{
    public partial class frmMenuUser : Form
    {
        public frmMenuUser()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {   this.Close();
            frmCompare compare = new frmCompare();
            compare.Show();
        }


        

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn logIn = new frmLogIn();
            logIn.Show();
        }
    }
}
