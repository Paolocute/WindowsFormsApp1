using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object i;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double LastName, FirstName, MiddleName;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
           string MM = comboBox1.GetItemText(comboBox1.SelectedItem);
           string DD = comboBox2.GetItemText(comboBox2.SelectedItem);
           string YYYY = comboBox3.GetItemText(comboBox3.SelectedItem);
           string gender = checkBox1.Checked == true ? "Male" : "Female";
            
            string LastName, FirstName, MiddleName;

            LastName = T1.Text;
            FirstName = T2.Text;
            MiddleName = T3.Text;

            MessageBox.Show("Student Name: " + FirstName + " " + MiddleName + " " + LastName + "\nGender: " + gender + "\nDate of Birth: " + DD + "/" + MM + "/" + YYYY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            for(int i = 0; i < 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for(int i = 1;i <=12; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            for(int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
        }
    }
  
}
