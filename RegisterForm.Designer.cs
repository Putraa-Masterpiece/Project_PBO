namespace Project_PBO
{
    partial class RegisterForm
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
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            comboBoxRole = new ComboBox();
            btnCancel = new Button();
            txtEmail = new TextBox();
            txtNoTelepon = new TextBox();
            txtNIK = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(315, 291);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(315, 353);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 263);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 325);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(523, 390);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Enabled = false;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(50, 106);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(182, 33);
            comboBoxRole.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(107, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(315, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtNoTelepon
            // 
            txtNoTelepon.Location = new Point(315, 167);
            txtNoTelepon.Name = "txtNoTelepon";
            txtNoTelepon.Size = new Size(150, 31);
            txtNoTelepon.TabIndex = 9;
            // 
            // txtNIK
            // 
            txtNIK.Location = new Point(315, 229);
            txtNIK.Name = "txtNIK";
            txtNIK.Size = new Size(150, 31);
            txtNIK.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 66);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 201);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 12;
            label5.Text = "NIK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 139);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 13;
            label6.Text = "Nomer_Telepon";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNIK);
            Controls.Add(txtNoTelepon);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxRole);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private ComboBox comboBoxRole;
        private Button btnCancel;
        private TextBox txtEmail;
        private TextBox txtNoTelepon;
        private TextBox txtNIK;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}