namespace Project_PBO
{
    partial class DashboardForm
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
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(489, 130);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(182, 33);
            comboBoxRole.TabIndex = 0;
            comboBoxRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxRole);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxRole;
    }
}