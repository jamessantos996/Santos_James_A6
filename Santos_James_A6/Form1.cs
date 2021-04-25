using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santos_James_A6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Checks if the first name, middle name, surname and student number is empty

            // if it's empty, the error message will show up           
            if (string.IsNullOrEmpty(firstName.Text.Trim()) || string.IsNullOrEmpty(middleName.Text.Trim()) || string.IsNullOrEmpty(surName.Text.Trim()) || string.IsNullOrEmpty(studentNumber.Text))
            {
                MessageBox.Show("Fields cannot be blank");
            }
            // if it's not empty, all the input fields will be pass into another form
            else
            {
                //concatenate the surname, first name and middle name
                string fullName = surName.Text + ", " + firstName.Text + " " + middleName.Text;

                //concatenate the birthmonth, birthday and birthyear
                string birthdate = birthMonth.Value + "/" + birthDay.Value + "/" + birthYear.Value;

                //create an instance of Form2 and passed all the values from the users
                Form2 submitForm = new Form2(fullName, studentNumber.Text, Convert.ToInt32(yearLevel.Value), birthdate);

                // this will hide the current form and show the submitForm
                this.Hide();
                submitForm.Show();
            }
            
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //create an instance of random class
            Random rand = new Random();
            
            //generate a random number between 10000 to 99999, and convert that into a string
            string num = Convert.ToString(rand.Next(10000, 99999));

            //concatenate the generated random number into a variable studentNum
            string studentNum = "PM-21-" + num;

            //Display the student number
            studentNumber.Text = studentNum;
        }
    }
}
