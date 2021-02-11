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
    public partial class Pay_Fees : Form
    {
        public Pay_Fees()
        {
            InitializeComponent();
        }

        private void Submit_fees_button_Click(object sender, EventArgs e)
        {if (registration_number_textBox.Text == "") MessageBox.Show("Please enter registration number");
           else if (fees_Paid_textBox.Text == "") MessageBox.Show("Please enter fees paid");
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=school.accdb");
                    con.Open();
                    OleDbCommand read_student = new OleDbCommand("SELECT * FROM student_table WHERE registration_number=" + Int32.Parse(registration_number_textBox.Text)+" ", con);
                    OleDbDataReader thisreader = read_student.ExecuteReader();
                    thisreader.Read();


                    int fee_paid = thisreader.GetInt32(4);
                    int current_fee_paid = fee_paid + Int32.Parse(fees_Paid_textBox.Text);
                    OleDbCommand update_student_fee = new OleDbCommand("UPDATE student_table SET fees_paid=" + current_fee_paid + " WHERE registration_number=" + Int32.Parse(registration_number_textBox.Text)+" ", con);
                    update_student_fee.ExecuteNonQuery();
                    MessageBox.Show("Fees successfully paid");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void go_to_admin_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void Pay_Fees_Load(object sender, EventArgs e)
        {

        }

        private void Pay_Fees_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    }

