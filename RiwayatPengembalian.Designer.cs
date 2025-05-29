namespace Project_PBO
{
    partial class RiwayatPengembalian
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
            dataGridRiwayatPengembalian = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRiwayatPengembalian).BeginInit();
            SuspendLayout();
            // 
            // dataGridRiwayatPengembalian
            // 
            dataGridRiwayatPengembalian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRiwayatPengembalian.Location = new Point(12, 87);
            dataGridRiwayatPengembalian.Name = "dataGridRiwayatPengembalian";
            dataGridRiwayatPengembalian.RowHeadersWidth = 62;
            dataGridRiwayatPengembalian.Size = new Size(776, 326);
            dataGridRiwayatPengembalian.TabIndex = 0;
            dataGridRiwayatPengembalian.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 30);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 48);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 2;
            label1.Text = "Riwayat Pengembalian";
            // 
            // RiwayatPengembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridRiwayatPengembalian);
            Name = "RiwayatPengembalian";
            Text = "RiwayatPengembalian";
            Load += RiwayatPengembalian_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridRiwayatPengembalian).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRiwayatPengembalian;
        private Button button1;
        private Label label1;
    }
}