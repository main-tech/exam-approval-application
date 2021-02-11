namespace School_Exam_approval
{
    partial class Pay_Fees
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
            this.Submit_fees_button = new System.Windows.Forms.Button();
            this.registration_number_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fees_Paid_textBox = new System.Windows.Forms.TextBox();
            this.go_to_admin_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit_fees_button
            // 
            this.Submit_fees_button.Location = new System.Drawing.Point(20, 179);
            this.Submit_fees_button.Name = "Submit_fees_button";
            this.Submit_fees_button.Size = new System.Drawing.Size(75, 23);
            this.Submit_fees_button.TabIndex = 0;
            this.Submit_fees_button.Text = "Submit fees";
            this.Submit_fees_button.UseVisualStyleBackColor = true;
            this.Submit_fees_button.Click += new System.EventHandler(this.Submit_fees_button_Click);
            // 
            // registration_number_textBox
            // 
            this.registration_number_textBox.Location = new System.Drawing.Point(12, 61);
            this.registration_number_textBox.Name = "registration_number_textBox";
            this.registration_number_textBox.Size = new System.Drawing.Size(100, 20);
            this.registration_number_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter registration number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter amount of fees to pay ";
            // 
            // fees_Paid_textBox
            // 
            this.fees_Paid_textBox.Location = new System.Drawing.Point(17, 117);
            this.fees_Paid_textBox.Name = "fees_Paid_textBox";
            this.fees_Paid_textBox.Size = new System.Drawing.Size(100, 20);
            this.fees_Paid_textBox.TabIndex = 3;
            // 
            // go_to_admin_button
            // 
            this.go_to_admin_button.Location = new System.Drawing.Point(188, 168);
            this.go_to_admin_button.Name = "go_to_admin_button";
            this.go_to_admin_button.Size = new System.Drawing.Size(75, 23);
            this.go_to_admin_button.TabIndex = 5;
            this.go_to_admin_button.Text = "Admin";
            this.go_to_admin_button.UseVisualStyleBackColor = true;
            this.go_to_admin_button.Click += new System.EventHandler(this.go_to_admin_button_Click);
            // 
            // Pay_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.go_to_admin_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fees_Paid_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registration_number_textBox);
            this.Controls.Add(this.Submit_fees_button);
            this.Name = "Pay_Fees";
            this.Text = "Pay_Fees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pay_Fees_FormClosing);
            this.Load += new System.EventHandler(this.Pay_Fees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_fees_button;
        private System.Windows.Forms.TextBox registration_number_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fees_Paid_textBox;
        private System.Windows.Forms.Button go_to_admin_button;
    }
}