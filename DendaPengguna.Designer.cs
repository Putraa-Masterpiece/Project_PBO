namespace Project_PBO
{
    partial class DendaPengguna
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
            dataGridView1 = new DataGridView();
            txtDenda = new TextBox();
            btnSimpanDenda = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(704, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtDenda
            // 
            txtDenda.Location = new Point(334, 314);
            txtDenda.Name = "txtDenda";
            txtDenda.Size = new Size(150, 31);
            txtDenda.TabIndex = 1;
            // 
            // btnSimpanDenda
            // 
            btnSimpanDenda.Location = new Point(642, 373);
            btnSimpanDenda.Name = "btnSimpanDenda";
            btnSimpanDenda.Size = new Size(112, 34);
            btnSimpanDenda.TabIndex = 2;
            btnSimpanDenda.Text = "Konfirmasi";
            btnSimpanDenda.UseVisualStyleBackColor = true;
            btnSimpanDenda.Click += btnSimpanDenda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 286);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "Total Denda";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(50, 373);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DendaPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnSimpanDenda);
            Controls.Add(txtDenda);
            Controls.Add(dataGridView1);
            Name = "DendaPengguna";
            Text = "DendaPengguna";
            Load += DendaPengguna_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtDenda;
        private Button btnSimpanDenda;
        private Label label1;
        private Button button1;
    }
}