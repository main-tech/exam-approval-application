using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace School_Exam_approval
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            select_course_comboBox.SelectedItem = "Computer Technology";
            year_study_comboBox.SelectedItem = "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fees_paid_textBox.Text == "") MessageBox.Show("Please enter fees paid");
            else if (student_name_textBox.Text == "") MessageBox.Show("Please enter student name");
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=school.accdb");
                    con.Open();
                    string insert_data = "INSERT INTO student_table(cours_name,study_year,student_name,fees_paid) VALUES('" + select_course_comboBox.Text + "'," + Int32.Parse(year_study_comboBox.Text) + ",'" + student_name_textBox.Text + "'," + Int32.Parse(fees_paid_textBox.Text) + ")";
                    OleDbCommand insert = new OleDbCommand(insert_data, con);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Student successfully registered to School System");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void go_to_pay_fees_form_button_Click(object sender, EventArgs e)
        {

            Pay_Fees form = new Pay_Fees();
            form.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
