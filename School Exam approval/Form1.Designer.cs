namespace School_Exam_approval
{
    partial class Form1
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
            this.registration_numnber_textBox = new System.Windows.Forms.TextBox();
            this.course_name_textBox = new System.Windows.Forms.TextBox();
            this.student_name_textBox = new System.Windows.Forms.TextBox();
            this.semester_textBox = new System.Windows.Forms.TextBox();
            this.exam_approval_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.check_exam_approval_button = new System.Windows.Forms.Button();
            this.go_to_adminform_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registration_numnber_textBox
            // 
            this.registration_numnber_textBox.Location = new System.Drawing.Point(65, 75);
            this.registration_numnber_textBox.Name = "registration_numnber_textBox";
            this.registration_numnber_textBox.Size = new System.Drawing.Size(100, 20);
            this.registration_numnber_textBox.TabIndex = 0;
            this.registration_numnber_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registration_numnber_textBox_KeyPress);
            // 
            // course_name_textBox
            // 
            this.course_name_textBox.Location = new System.Drawing.Point(686, 110);
            this.course_name_textBox.Name = "course_name_textBox";
            this.course_name_textBox.ReadOnly = true;
            this.course_name_textBox.Size = new System.Drawing.Size(117, 20);
            this.course_name_textBox.TabIndex = 1;
            // 
            // student_name_textBox
            // 
            this.student_name_textBox.Location = new System.Drawing.Point(686, 30);
            this.student_name_textBox.Name = "student_name_textBox";
            this.student_name_textBox.ReadOnly = true;
            this.student_name_textBox.Size = new System.Drawing.Size(117, 20);
            this.student_name_textBox.TabIndex = 2;
            // 
            // semester_textBox
            // 
            this.semester_textBox.Location = new System.Drawing.Point(686, 171);
            this.semester_textBox.Name = "semester_textBox";
            this.semester_textBox.ReadOnly = true;
            this.semester_textBox.Size = new System.Drawing.Size(117, 20);
            this.semester_textBox.TabIndex = 3;
            // 
            // exam_approval_textBox
            // 
            this.exam_approval_textBox.Location = new System.Drawing.Point(686, 243);
            this.exam_approval_textBox.Name = "exam_approval_textBox";
            this.exam_approval_textBox.ReadOnly = true;
            this.exam_approval_textBox.Size = new System.Drawing.Size(117, 20);
            this.exam_approval_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter registration number in the text box below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year of Study";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(556, 250);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Exam approval";
            // 
            // check_exam_approval_button
            // 
            this.check_exam_approval_button.Location = new System.Drawing.Point(65, 143);
            this.check_exam_approval_button.Name = "check_exam_approval_button";
            this.check_exam_approval_button.Size = new System.Drawing.Size(75, 48);
            this.check_exam_approval_button.TabIndex = 12;
            this.check_exam_approval_button.Text = "Check exam approval";
            this.check_exam_approval_button.UseVisualStyleBackColor = true;
            this.check_exam_approval_button.Click += new System.EventHandler(this.check_exam_approval_button_Click);
            // 
            // go_to_adminform_button
            // 
            this.go_to_adminform_button.Location = new System.Drawing.Point(65, 407);
            this.go_to_adminform_button.Name = "go_to_adminform_button";
            this.go_to_adminform_button.Size = new System.Drawing.Size(75, 23);
            this.go_to_adminform_button.TabIndex = 13;
            this.go_to_adminform_button.Text = "Admin Form";
            this.go_to_adminform_button.UseVisualStyleBackColor = true;
            this.go_to_adminform_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 462);
            this.Controls.Add(this.go_to_adminform_button);
            this.Controls.Add(this.check_exam_approval_button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exam_approval_textBox);
            this.Controls.Add(this.semester_textBox);
            this.Controls.Add(this.student_name_textBox);
            this.Controls.Add(this.course_name_textBox);
            this.Controls.Add(this.registration_numnber_textBox);
            this.Name = "Form1";
            this.Text = "Confirm Exam Approval";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registration_numnber_textBox;
        private System.Windows.Forms.TextBox course_name_textBox;
        private System.Windows.Forms.TextBox student_name_textBox;
        private System.Windows.Forms.TextBox semester_textBox;
        private System.Windows.Forms.TextBox exam_approval_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button check_exam_approval_button;
        private System.Windows.Forms.Button go_to_adminform_button;
    }
}

