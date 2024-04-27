using System;
using System.Collections;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void DisplayInfo(string LastName, string FirstName, string MiddleName, string Gender, string Month, string Day, string Year, string Program)
        {
            MessageBox.Show("Student Name: " + LastName + ", " + FirstName + " " + MiddleName + "\nGender: " + Gender +
          "\nDate of Birth: " + Month + "/" + Day + "/" + Year + "\nProgram: " + Program);
        }

        public void DisplayInfo(string LastName, string FirstName, string MiddleName, string Gender, string Program)
        {
            MessageBox.Show("Student Name: " + LastName + ", " + FirstName + " " + MiddleName + "\nGender: " + Gender + "\nProgram: " + Program);
        }

        public void DisplayInfo(string LastName, string FirstName, string MiddleName, string Program)
        {
            MessageBox.Show("Student Name: " + LastName + ", " + FirstName + " " + MiddleName + "\nProgram: " + Program);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            ArrayList monthList = new ArrayList();
            monthList.Add(" January ");
            monthList.Add(" February ");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            foreach (string month in monthList)
            {
                comboBox2.Items.Add(month);
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }

            ArrayList programList = new ArrayList();
            programList.Add("Bachelor of Science in Information Technology");
            programList.Add("Bachelor of Science in Computer Science");
            programList.Add("Bachelor of Science in Information Systems");
            programList.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in programList)
            {
                comboBox4.Items.Add(program);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox1.GetItemText(comboBox1.SelectedItem);
            string DD = comboBox2.GetItemText(comboBox2.SelectedItem);
            string YYYY = comboBox3.GetItemText(comboBox3.SelectedItem);
            string gender = radioButton1.Checked == true ? "Male" : "Female";
            string program = comboBox4.GetItemText(comboBox4.SelectedItem);
            string LastName, FirstName, MiddleName;
            LastName = textBox1.Text;
            FirstName = textBox2.Text;
            MiddleName = textBox3.Text;

            DisplayInfo(LastName, FirstName, MiddleName, gender, month, DD, YYYY, program);
            DisplayInfo(LastName, FirstName, MiddleName, gender, program);
            DisplayInfo(LastName, FirstName, MiddleName, program);

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}

