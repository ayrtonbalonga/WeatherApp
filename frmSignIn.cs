using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weatherapp
{
    public partial class frmSignIn : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2.2\POE Ayrton Balonga 17611047 Task 2\Weatherapp\Weather.mdf;Integrated Security=True");
        public String[,] Data = new string[100, 7];
        public frmSignIn()
        {
            InitializeComponent();
        }
      


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //Declaration of variables
            String name, surname, email, username, password, repassword;

            name = tEName.Text;
            surname = tESurname.Text;
            email = tEEmail.Text;
            password = tEPassword.Text;
            repassword = tERepassword.Text;
            username = tEUsername.Text;
            Boolean isNormalUser = false;

            readData();



            if ((name == "") && (surname == "") && (email == "") && (username == "") && (password == "") && (repassword == "") && (password != repassword))
            {
                MessageBox.Show("the information that you have input are incorrect, please correct them");
                //MessageBox.Show("the passerd that you have input are not matching, please input the same password");
            }
            else
            {
              
                if (cbYes.Checked)
                {
                    isNormalUser = true;

                    check(isNormalUser);

                }
                else
                {
                    isNormalUser = false;
                    check(isNormalUser);
                }
                MessageBox.Show("the profil of the user has been created");
            }

        }


        public void StoreData(String name, String surname, String email, String username, String password,Boolean isNormalUser)// declaration of the method
        {

            if ((tEName.Text == "") && (tESurname.Text == "") && (tEEmail.Text == "") && (tEPassword.Text == "") && (tEUsername.Text == "") && (tEPassword.Text != tERepassword.Text))
            {

                MessageBox.Show("there data you have input is incorrect ");
            }
            else
            {
                try
                {
                    conn.Open();

                    String sqlInsert = "insert into ForcastUser(usName,usSurname,usUsername,usEmail,usPassword,isNormalUser) Values(@usName,@usSurname,@usUsername,@usEmail,@usPassword,@isNormalUser)";
                    SqlCommand commad = new SqlCommand(sqlInsert, conn);
                    commad.Parameters.AddWithValue("@usName", tEName.Text);
                    commad.Parameters.AddWithValue("@usSurname", tESurname.Text);
                    commad.Parameters.AddWithValue("@usUsername", tEUsername.Text);
                    commad.Parameters.AddWithValue("@usEmail", tEEmail.Text);
                    commad.Parameters.AddWithValue("@usPassword", tEPassword.Text);
                    commad.Parameters.AddWithValue("isNormalUser", isNormalUser.ToString());
                   
                    commad.ExecuteNonQuery();
                    MessageBox.Show("Record have been saved successfully");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }


            }

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
                Data[a, 3] = row["usEmail"].ToString();
                Data[a, 4] = row["usPassword"].ToString();
                Data[a, 5] = row["usPassword"].ToString();
                Data[a, 6] = row["isNormalUser"].ToString();


                a++;

            }
        }

        public void check(Boolean isNormalUser)
        {
            //Declaration of variables
            Boolean isCorrect = false;

            String name, surname, email, username, password, repassword;

            name = tEName.Text;
            surname = tESurname.Text;
            email = tEEmail.Text;
            password = tEPassword.Text;
            repassword = tERepassword.Text;
            username = tEUsername.Text;
            for (int i = 0; i < 100; i++)
            {

                if (username == Data[i, 3] && (password == Data[i, 5]))   // if the username that has been outby the user is equal to the username that is in the text file,and the password that  is in the text file is equal to the password that user has input then
                {

                    isCorrect = true;

                    MessageBox.Show("the username and passowrd that you have enter exist already,Click on Log in");

                }
                else
                {
                    isCorrect = false;
                    

                }


            }
            if (isCorrect==false)
            {
                StoreData(name, surname, email, username, password, isNormalUser);
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn logIn = new frmLogIn();
            logIn.Show();
        }
    }
}

    

