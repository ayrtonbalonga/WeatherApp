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
    public partial class frmInput : Form
    {
        //private object forcastUserBindingSource;
        //private object forcastUserTableAdapter;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2.2\POE Ayrton Balonga 17611047 Task 2\Weatherapp\Weather.mdf;Integrated Security=True");
        public frmInput()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            //Declaration of the variable
            //  String city, date, humidity, max, min, precipitation, windSpeed;


            //get the information from the user
            //city = cbCity.Text;
            //date = dtDate.Value.ToString("dd-MM-yyyy");
            //humidity = tEditHumi.Text;
            //max = tEditMax.Text;
            //min = tEditMin.Text;
            //precipitation = tEditPreci.Text;
            //windSpeed = tEditWind.Text;
            //if (CollectData() == true)
            //{
            //    MessageBox.Show("the information that you have input is already in the text file");
            //}
            //else
            //{
            //    if ((cbCity.Text == "") || (tEditHumi.Text == "") || (tEditMax.Text == "") || (tEditMin.Text == "") || (tEditPreci.Text == "") || (tEditWind.Text == ""))
            //    {


            //        MessageBox.Show("Error, Data Cannot be input,input correct informations"); // then display this messsage

            //    }
            //    else
            //    {
            //        StoreData(city, date, humidity, max, min, precipitation, windSpeed);    // calling the method with parameter 


            //    }
            //}
            //MessageBox.Show("The information have been stored succesfully");


            //if any of the component are empty, 


        }

        public void StoreData(String city, String date, String humidity, String max, String min, String precipitation, String windSpeed)// declaration of the method
        {

            using (StreamWriter sw = new StreamWriter("Data.txt", true))   /// this will help writing the data in th text file
            //in ortder for the program to run properly, you need to put the correct path of the text file on the top
            {

                String line = city + "," + date + "," + humidity + "," + max + "," + min + "," + precipitation + "," + windSpeed + ",";  // puting the data into one string 

                sw.WriteLine(line);  //puting line in the text file

                sw.Close();  // closing the text file

            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //tEditHumi.Clear();   //clean the edit field
            //tEditMax.Clear();  //clean the edit field
            //tEditMin.Clear();//clean the edit field
            //tEditPreci.Clear();//clean the edit field
            //tEditWind.Clear();//clean the edit field
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();  //closing the imput from
            frmMenu Menu = new frmMenu();   //initialisation of the menu from
            Menu.Show();   //open menu form
        }


        public Boolean CollectData()
        {
            Boolean isfound = false;
            //Declaration of variable
            String city, date, humidity, max, min, precipitation, windSpeed;





            StreamReader sr = new StreamReader("Data.txt", true);  // help to read the in the text file
                                                                   //in ortder for the program to run properly, you need to put the correct path of the text file on the top

            String line = "";
            char comma = ',';
            String sline = "";


            int i = 0;


            while ((line = sr.ReadLine()) != null)  // reading the text file line by line until it's end
            {

                sline = line;        // getting the current line of the text file 
                city = sline.Substring(0, (sline.IndexOf(comma)));   //getting the city from the current line

                sline = sline.Remove(0, sline.IndexOf(comma) + 1); // delete the date from the line

                date = sline.Substring(0, (sline.IndexOf(comma))); //getting the date from the current line

                sline = sline.Remove(0, sline.IndexOf(comma) + 1); // delete the date from the line

                //MessageBox.Show(sline);
                humidity = sline.Substring(0, (sline.IndexOf(comma)));//getting the humidity  from the current line
                sline = sline.Remove(0, (sline.IndexOf(comma)) + 1);// delete humidity from the line
                max = sline.Substring(0, (sline.IndexOf(comma)));//getting the maximum temperature from the current line
                sline = sline.Remove(0, sline.IndexOf(comma) + 1); // delete the date from the line
                min = sline.Substring(0, (sline.IndexOf(comma)));//getting the minimum temperature from the current line
                sline = sline.Remove(0, sline.IndexOf(comma) + 1); // delete the date from the line
                precipitation = sline.Substring(0, (sline.IndexOf(comma)));//getting the precipitation  from the current line
                sline = sline.Remove(0, sline.IndexOf(comma) + 1); // delete the date from the line
                windSpeed = sline;//getting the wind speed from the current line



                //storing the data that have been collected from the text file into the array


                i++;
            }
            sr.Close(); //closing the text file


            return isfound;
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            IdtextBox.Clear();

            humidityTextBox.Clear();
            maxTempTextBox.Clear();
            minTempTextBox.Clear();
            precipitationTextBox.Clear();
            windSpeedTextBox.Clear();

        }



        private void frmInput_Load(object sender, EventArgs e)
        {
            displayData();


    

        }

        public void displayData()
        {
            conn.Open();
            string refresh = "SELECT*FROM Weather";



            SqlDataAdapter cmd = new SqlDataAdapter(refresh, conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            weatherDataGridView.DataSource = dt;
            conn.Close();
        }

        





        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
               // int id = Int32.Parse(IdtextBox.Text);
                conn.Open();
                string refresh = "delete from Weather where Id = '" + Int32.Parse(IdtextBox.Text) + "'";

                SqlDataAdapter cmd = new SqlDataAdapter(refresh, conn);
                cmd.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record have been deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
       
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = "UPDATE Weather SET Humidity = @Humidity, MaxTemp = @MaxTemp , MinTemp = @minTemp , Precipitation = @Precipitation , WindSpeed = @WindSpeed Where Id =@Id ";

                

                    command.Parameters.AddWithValue("@Id", Int32.Parse(IdtextBox.Text));
                    command.Parameters.AddWithValue("@Humidity", Int32.Parse(humidityTextBox.Text));
                    command.Parameters.AddWithValue("@MaxTemp", Int32.Parse(maxTempTextBox.Text));
                    command.Parameters.AddWithValue("@minTemp", Int32.Parse(minTempTextBox.Text));
                    command.Parameters.AddWithValue("@Precipitation", Int32.Parse(precipitationTextBox.Text));
                    command.Parameters.AddWithValue("@WindSpeed", Int32.Parse(windSpeedTextBox.Text));

                    conn.Open();

                    command.ExecuteNonQuery();

                    conn.Close();
                }

            }
         

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {





            if ((humidityTextBox.Text == "") && (maxTempTextBox.Text == "") && (minTempTextBox.Text == "") && (precipitationTextBox.Text == "") && (windSpeedTextBox.Text == ""))
            {

                MessageBox.Show("there data you have input is incorrect ");
            }
            else
            {
                try
                {


                    
                                conn.Open();

                                String sqlInsert = "insert into Weather(City, sDate, Humidity, MaxTemp, MinTemp, Precipitation, WindSpeed) Values(@City,@sDate,@Humidity,@MaxTemp,@MinTemp,@Precipitation,@WindSpeed)";
                                SqlCommand commad = new SqlCommand(sqlInsert, conn);
                                commad.Parameters.AddWithValue("@City", cbCity.Text);
                                commad.Parameters.AddWithValue("@sDate", sDateDateTimePicker.Text);
                                commad.Parameters.AddWithValue("@Humidity", humidityTextBox.Text);
                                commad.Parameters.AddWithValue("@MaxTemp", maxTempTextBox.Text);
                                commad.Parameters.AddWithValue("@minTemp", minTempTextBox.Text);
                                commad.Parameters.AddWithValue("@Precipitation", precipitationTextBox.Text);
                                commad.Parameters.AddWithValue("@WindSpeed", windSpeedTextBox.Text);


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
                try
                {
                    displayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }




        }

        private void weatherDataGridView_DoubleClick(object sender, EventArgs e)
        {
            IdtextBox.Text = weatherDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbCity.Text = weatherDataGridView.CurrentRow.Cells[1].Value.ToString();
            sDateDateTimePicker.Value = DateTime.Parse(this.weatherDataGridView.CurrentRow.Cells[2].Value.ToString());
            humidityTextBox.Text = weatherDataGridView.CurrentRow.Cells[3].Value.ToString();
            maxTempTextBox.Text = weatherDataGridView.CurrentRow.Cells[4].Value.ToString();
            minTempTextBox.Text = weatherDataGridView.CurrentRow.Cells[5].Value.ToString();
            precipitationTextBox.Text = weatherDataGridView.CurrentRow.Cells[6].Value.ToString();
            windSpeedTextBox.Text = weatherDataGridView.CurrentRow.Cells[7].Value.ToString();


        }
    }
}

