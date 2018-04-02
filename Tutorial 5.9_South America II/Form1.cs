using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Tutorial_5._9_South_America_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable totoal to hold a country name.
                string countryName;

                //Declare a StreamReader Variable.
                StreamReader inputFile;

                //Open the file and get a streamReader object.
                inputFile = File.OpenText("Countries.txt");

                //Clear anything current in the Listbox.
                countriesListBox.Items.Clear();

                //Read the file contents.
                while (!inputFile.EndOfStream)
                {
                    //Get a country name.
                    countryName = inputFile.ReadLine();

                    //Add the country name to the ListBox.
                    countriesListBox.Items.Add(countryName);
                }

                //Close the file.
                inputFile.Close();

            }
            catch (Exception ex)
            {
                //Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}

