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
    public partial class Form2 : Form
    {
        private string name;
        private string studentNumber;
        private int yearLevel;
        private string birthday;

        public Form2(string name, string studentNumber, int yearLevel, string birthday)
        {
            this.name = name;
            this.studentNumber = studentNumber;
            this.yearLevel = yearLevel;
            this.birthday = birthday;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fName.Text = this.name;
            sNumber.Text = this.studentNumber;
            yLevel.Text = Convert.ToString(this.yearLevel);
            bday.Text = this.birthday;
        }

        private void buttonSubmitAnother_Click(object sender, EventArgs e)
        {
            Form1 submitForm = new Form1();

            this.Hide();
            submitForm.Show();
        }
    }
}
