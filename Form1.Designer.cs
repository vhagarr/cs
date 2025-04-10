namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            numAge = new NumericUpDown();
            rtbAddress = new RichTextBox();
            txtMobile = new TextBox();
            cmbDepartment = new ComboBox();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(369, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(301, 27);
            txtName.TabIndex = 0;
            // 
            // numAge
            // 
            numAge.Location = new Point(369, 45);
            numAge.Name = "numAge";
            numAge.Size = new Size(301, 27);
            numAge.TabIndex = 1;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(375, 85);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(295, 74);
            rtbAddress.TabIndex = 2;
            rtbAddress.Text = "";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(375, 183);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(295, 27);
            txtMobile.TabIndex = 3;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(375, 250);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(295, 28);
            cmbDepartment.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(375, 299);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(459, 357);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(102, 45);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 52);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 8;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 88);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 190);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 10;
            label4.Text = "Mobile No .";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 258);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 11;
            label5.Text = "Select Deparment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 306);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 12;
            label6.Text = "Email Id ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(cmbDepartment);
            Controls.Add(txtMobile);
            Controls.Add(rtbAddress);
            Controls.Add(numAge);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private NumericUpDown numAge;
        private RichTextBox rtbAddress;
        private TextBox txtMobile;
        private ComboBox cmbDepartment;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
