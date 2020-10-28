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
using System.Data.SqlClient;

namespace Weatherapp
{
    public partial class frmCompare : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2.2\POE Ayrton Balonga 17611047 Task 2\Weatherapp\Weather.mdf;Integrated Security=True");
        public String[,] Data = new string[100, 8];
        public String[,] arrReport = new string[100, 8];

        //  List<d> DataWeather = new List<T>(); 

        public frmCompare()
        {
            InitializeComponent();
        }
        private void BtnDisplay1_Click_1(object sender, EventArgs e)
        {
            // Declaration of the variables
            String city;
            DateTime start, end;


            CollectData(); //calling the method

            city = cbCity.Text;                //getting the city from the user
            start = DateTime.Parse(dtStart.Value.ToString("dd-MM-yyyy"));  //getting the starting date from the user 
            end = DateTime.Parse(dtEnd.Value.ToString("dd-MM-yyyy"));   //getting the ending date from the user

            String date = dtEnd.Value.ToString("dd-MM-yyyy");
            // MessageBox.Show(dtEnd.Value.ToString("dd-MM-yyyy"));
            Report(city, start, end);  //calling the method of  with parameter



            //MessageBox.Show(Data[0,2]);



        }

        public bool isRangeDate(DateTime curr, DateTime start, DateTime end)
        {
            return curr >= start && curr <= end;
        }

        public void Report(String city, DateTime start, DateTime end)
        {
            //Declaation of variable

            //Boolean isfound = false;

            rtDisplay.Text = "REPORT \n\n";

            for (int i = 0; i < 100; i++)
            {


                //if  the date that user as imput is equal to the the city that is in the text file and the starting date that the user have imput is equal to the one that is in the text file and the ending dat that the user has input is equal to the on that is in the text file then

                if ((Data[i, 1] == city) && (isRangeDate(DateTime.Parse(Data[i, 2]), start, end)))

                {


                    for (int j = 0; j < 8; j++)
                    {

                        // isfound = true;

                        arrReport[i, j] = Data[i, j];  // store the data in the array

                        //MessageBox.Show(arrReport[i,j]);

                    }

                    rtDisplay.Text += "City: " + arrReport[i, 1] + "\n Date:" + arrReport[i, 2] + "\nHumidity:" + arrReport[i, 3] + "\nMaximum Temperature:" + arrReport[i, 4]
                 + "\nMininum Temperature:" + arrReport[i, 5] + "\nPrecipitation:" + arrReport[i, 6] + "\nWind speed:" + arrReport[i, 7] + "\n\n";
                }

            }
            //if (isfound == false)
            //{

            //    MessageBox.Show("the data that you have input are were not find in the text file");

            //}
        }

        public void CollectData()
        {

            conn.Open();
            string refresh = "SELECT * FROM Weather";

            SqlDataAdapter cmd = new SqlDataAdapter(refresh, conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            //weatherDataGridView.DataSource = dt;
            conn.Close();

            int a = 0;

            foreach (DataRow row in dt.Rows)
            {


                Data[a, 0] = row["Id"].ToString();
                Data[a, 1] = row["City"].ToString();
                // Data[a, 2] = DateTime.Parse( row["sDate"].ToString());

                String Date = row["sDate"].ToString();
                Data[a, 2] = Date.Substring(0, 11);

                //  MessageBox.Show(Data[a,2]);

                // DateTime.Parse(dtEnd1.Value.ToString("dd-MM-yyyy"));
                Data[a, 3] = row["Humidity"].ToString();
                Data[a, 4] = row["MaxTemp"].ToString();
                Data[a, 5] = row["MinTemp"].ToString();
                Data[a, 6] = row["Precipitation"].ToString();
                Data[a, 7] = row["WindSpeed"].ToString();

                a++;




            }
        }

        private void BtnClear1_Click(object sender, EventArgs e)
        {
            rtDisplay.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();


        }
    }
    }
    
    

