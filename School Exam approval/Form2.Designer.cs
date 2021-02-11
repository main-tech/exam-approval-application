namespace School_Exam_approval
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.year_study_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.student_name_textBox = new System.Windows.Forms.TextBox();
            this.fees_paid_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.go_to_pay_fees_form_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "year of study";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exam approval form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_course_comboBox
            // 
            this.select_course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_comboBox.FormattingEnabled = true;
            this.select_course_comboBox.Items.AddRange(new object[] {
            "Computer Technology",
            "Computer Science",
            "IT"});
            this.select_course_comboBox.Location = new System.Drawing.Point(557, 73);
            this.select_course_comboBox.Name = "select_course_comboBox";
            this.select_course_comboBox.Size = new System.Drawing.Size(121, 21);
            this.select_course_comboBox.TabIndex = 2;
            // 
            // year_study_comboBox
            // 
            this.year_study_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_study_comboBox.FormattingEnabled = true;
            this.year_study_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.year_study_comboBox.Location = new System.Drawing.Point(557, 153);
            this.year_study_comboBox.Name = "year_study_comboBox";
            this.year_study_comboBox.Size = new System.Drawing.Size(121, 21);
            this.year_study_comboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Course";
            // 
            // student_name_textBox
            // 
            this.student_name_textBox.Location = new System.Drawing.Point(557, 209);
            this.student_name_textBox.Name = "student_name_textBox";
            this.student_name_textBox.Size = new System.Drawing.Size(121, 20);
            this.student_name_textBox.TabIndex = 5;
            // 
            // fees_paid_textBox
            // 
            this.fees_paid_textBox.Location = new System.Drawing.Point(557, 305);
            this.fees_paid_textBox.Name = "fees_paid_textBox";
            this.fees_paid_textBox.Size = new System.Drawing.Size(121, 20);
            this.fees_paid_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fees paid";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Register  Student to Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // go_to_pay_fees_form_button
            // 
            this.go_to_pay_fees_form_button.Location = new System.Drawing.Point(119, 393);
            this.go_to_pay_fees_form_button.Name = "go_to_pay_fees_form_button";
            this.go_to_pay_fees_form_button.Size = new System.Drawing.Size(60, 56);
            this.go_to_pay_fees_form_button.TabIndex = 10;
            this.go_to_pay_fees_form_button.Text = "Pay Fess Form";
            this.go_to_pay_fees_form_button.UseVisualStyleBackColor = true;
            this.go_to_pay_fees_form_button.Click += new System.EventHandler(this.go_to_pay_fees_form_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 470);
            this.Controls.Add(this.go_to_pay_fees_form_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fees_paid_textBox);
            this.Controls.Add(this.student_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_study_comboBox);
            this.Controls.Add(this.select_course_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Confirtm Exam Approval Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox select_course_comboBox;
        private System.Windows.Forms.ComboBox year_study_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox student_name_textBox;
        private System.Windows.Forms.TextBox fees_paid_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button go_to_pay_fees_form_button;
    }
}