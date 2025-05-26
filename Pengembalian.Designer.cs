namespace Project_PBO
{
    partial class Pengembalian
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
            dataGridPengembalian = new DataGridView();
            btnKonfirmasi = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPengembalian).BeginInit();
            SuspendLayout();
            // 
            // dataGridPengembalian
            // 
            dataGridPengembalian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPengembalian.Location = new Point(28, 63);
            dataGridPengembalian.Name = "dataGridPengembalian";
            dataGridPengembalian.RowHeadersWidth = 62;
            dataGridPengembalian.Size = new Size(735, 285);
            dataGridPengembalian.TabIndex = 0;
            dataGridPengembalian.CellClick += dataGridPengembalian_CellClick;
            dataGridPengembalian.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(279, 370);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(265, 34);
            btnKonfirmasi.TabIndex = 1;
            btnKonfirmasi.Text = "Konfirmasi Pengembalian";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 23);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 2;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pengembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(dataGridPengembalian);
            Name = "Pengembalian";
            Text = "Pengembalian";
            Load += Pengembalian_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPengembalian).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPengembalian;
        private Button btnKonfirmasi;
        private Button button1;
    }
}