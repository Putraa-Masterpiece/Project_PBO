namespace Project_PBO
{
    partial class ProfilUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilUser));
            txtEmail = new TextBox();
            txtNoTelepon = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(284, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 31);
            txtEmail.TabIndex = 0;
            // 
            // txtNoTelepon
            // 
            txtNoTelepon.Enabled = false;
            txtNoTelepon.Location = new Point(284, 283);
            txtNoTelepon.Name = "txtNoTelepon";
            txtNoTelepon.Size = new Size(210, 31);
            txtNoTelepon.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(284, 338);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 31);
            txtUsername.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(319, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(332, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProfilUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(txtNoTelepon);
            Controls.Add(txtEmail);
            Name = "ProfilUser";
            Text = "ProfilUser";
            Load += ProfilUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtNoTelepon;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Button btnCancel;
    }
}