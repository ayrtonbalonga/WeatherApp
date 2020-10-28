using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Weatherapp
{
    public partial class frmLogIn : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2.2\POE Ayrton Balonga 17611047 Task 2\Weatherapp\Weather.mdf;Integrated Security=True");
        public String[,] Data = new string[100, 7];

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            Boolean isNormalUser = false;
            frmMenu Menu = new frmMenu();// initialisation of the form menu 

            readData();

           //MessageBox.Show(Data[0,5]);

            if (cbYes.Checked == true)
            {
                isNormalUser = true;

                checkAndLogIn1(isNormalUser);
            }
            else
            {

                isNormalUser = false;

                checkAndLogIn2(isNormalUser);



            }
        }

            private void BtnClear_Click(object sender, EventArgs e)
            {
                tEditUserName.Clear();    //  clean the edit file 
                tEditPassword.Clear();    //  clean the edit file 


            }

            private void BtnExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void BtnSignIn_Click(object sender, EventArgs e)
            {
                this.Hide();
                frmSignIn signIn = new frmSignIn();
                signIn.Show();

            }

            public void readData()
            {
                conn.Open();
                string refresh = "SELECT * FROM ForcastUser";

                SqlDataAdapter cmd = new SqlDataAdapter(refresh, conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                //weatherDataGridView.DataSource = dt;
                conn.Close();
                int a = 0;

                foreach (DataRow row in dt.Rows)
                {


                    Data[a, 0] = row["Id"].ToString();
                    Data[a, 1] = row["usName"].ToString();
                    Data[a, 2] = row["usSurname"].ToString();
                    Data[a, 3] = row["usUsername"].ToString();

                    Data[a, 4] = row["usEmail"].ToString();
                    Data[a, 5] = row["usPassword"].ToString();
                    Data[a, 6] = row["isNormalUser"].ToString();
                
                a++;




                }
            }

        public void checkAndLogIn1(Boolean isNormalUser)
        {
            //Declaration of variables
            
            string userName, password;
            Boolean isCorrect = false;
            String[,] username = new string[100, 3];

            
            userName = tEditUserName.Text;  // getting the username from the user
            password = tEditPassword.Text;  // getting the password from the user



            for (int i = 0; i < 7; i++)
            {

                username[i, 0] = Data[i, 3];  // the information that is  in the current line of the text file to the array
                username[i, 1] = Data[i, 5];
                username[i, 2] = Data[i, 6];
            }

            for (int i = 0; i < 8; i++)
            {


                if (userName == username[i, 0] && (password == username[i, 1]) && (username[i, 2] == isNormalUser.ToString()) )  // if the username that has been outby the user is equal to the username that is in the text file,and the password that  is in the text file is equal to the password that user has input then
                {

                    isCorrect = true;
                    this.Hide();            // hide the login form
                                 
                    frmMenuUser menu1 = new frmMenuUser();

                    menu1.Show();
                }


            }

            if (isCorrect == false)
            {
                MessageBox.Show("the username or password is invald");
            }


        }
        public void checkAndLogIn2(Boolean isNormalUser)
        {
            //Declaration of variables

            string userName, password;
            Boolean isCorrect = false;
            String[,] username = new string[100, 3];


            userName = tEditUserName.Text;  // getting the username from the user
            password = tEditPassword.Text;  // getting the password from the user



            for (int i = 0; i < 7; i++)
            {

                username[i, 0] = Data[i, 3];  // the information that is  in the current line of the text file to the array
                username[i, 1] = Data[i, 5];
                username[i, 2] = Data[i, 6];
            }

            for (int i = 0; i < 8; i++)
            {


                if (userName == username[i, 0] && (password == username[i, 1]) && (username[i, 2] == isNormalUser.ToString()))  // if the username that has been outby the user is equal to the username that is in the text file,and the password that  is in the text file is equal to the password that user has input then
                {

                    isCorrect = true;
                    this.Hide();            // hide the login form

                    frmMenu menu = new frmMenu();

                    menu.Show();
                }


            }

            if (isCorrect == false)
            {
                MessageBox.Show("the username or password is invald");
            }


        }
    }
    }
