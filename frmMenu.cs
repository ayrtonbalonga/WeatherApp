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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
                this.Close();       // hide the menu form 

            frmInput imput = new frmInput(); // initialise input from 

           imput.Show();   //open imput form

        }

        

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            frmCompare Compare = new frmCompare();// initialise compare from 
            this.Close();// hide the menu form 

            Compare.Show();// open compare form
        }

        

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn logIn = new frmLogIn();
            logIn.Show();
        }
    }
}
