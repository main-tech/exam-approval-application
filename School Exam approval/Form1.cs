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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_exam_approval_button_Click(object sender, EventArgs e)
        {
            if (!(registration_numnber_textBox.Text == ""))
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=school.accdb");
                    con.Open();
                    OleDbCommand read_student = new OleDbCommand("SELECT * FROM student_table WHERE registration_number=" + Int16.Parse(registration_numnber_textBox.Text), con);
                    OleDbDataReader thisreader = read_student.ExecuteReader();
                    thisreader.Read();

                    student_name_textBox.Text = thisreader.GetString(1);
                    course_name_textBox.Text = thisreader.GetString(2);
                    semester_textBox.Text = thisreader.GetInt32(3).ToString();
                    string course = thisreader.GetString(2);
                    int fee_paid = thisreader.GetInt32(4);
                    OleDbCommand feescmd = new OleDbCommand("SELECT * FROM course_fees WHERE course_name='" + course + "'", con);
                    OleDbDataReader thisreader1 = feescmd.ExecuteReader();
                    thisreader1.Read();
                    int fee_expected = thisreader1.GetInt32(1);
                    if (fee_paid >= fee_expected)
                    {
                        exam_approval_textBox.Text = "Allowed";
                    }
                    else exam_approval_textBox.Text = "Not Allowed";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Please enter registration number starting from 1");
        }

        private void registration_numnber_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
