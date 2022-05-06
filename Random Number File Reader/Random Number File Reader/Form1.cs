using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // <= Required to read files.

namespace Random_Number_File_Reader
{
    public partial class FormRandomNumberFileReader : Form
    {

        /*Author: Gustavo Marin Borges
         Title: Random Number File Reader*/

        public FormRandomNumberFileReader()
        {
            InitializeComponent();
        }

        private void FormRandomNumberFileReader_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This App will let you search for a file with numbers and you can open its content.", "Description.");
        }

        private void buttonGetValues_Click(object sender, EventArgs e)
        {
            try
            {
                string numberGen;
                int countNumber = 0;

                //Declare a StreamReader variable.
                StreamReader inputFile;

                //Open the file and get a StreamReader object.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    //Clear anything currently in the ListBox and DisplayLabel.
                    listBoxRandomDisplay.Items.Clear();
                    labelRandomDisplay.Text = "";

                    while (!inputFile.EndOfStream)
                    {
                        //Get Number.
                        numberGen = inputFile.ReadLine();

                        //Add the number to the box.
                        listBoxRandomDisplay.Items.Add(numberGen);
                        countNumber++;
                    }

                    //Displays total numbers.                    
                    labelRandomDisplay.Text = countNumber.ToString("N1");

                    //Close the file.
                    inputFile.Close();

                }
                else
                {
                    MessageBox.Show("Operation canceled.");
                }
            }
            catch (Exception ex)
            {
                //Display Error message.
                MessageBox.Show(ex.Message, "Error.");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear anything currently in the ListBox and DisplayLabel.
            listBoxRandomDisplay.Items.Clear();
            labelRandomDisplay.Text = "";

            //Reset the focus.
            buttonGetValues.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
