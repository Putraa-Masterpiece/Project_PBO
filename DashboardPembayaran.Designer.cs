namespace Project_PBO
{
    partial class DashboardPembayaran
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
            dataGridPenyewaan = new DataGridView();
            cmbMetodePembayaran = new ComboBox();
            txtTotalHarga = new TextBox();
            btnBayar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPenyewaan).BeginInit();
            SuspendLayout();
            // 
            // dataGridPenyewaan
            // 
            dataGridPenyewaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPenyewaan.Location = new Point(21, 32);
            dataGridPenyewaan.Name = "dataGridPenyewaan";
            dataGridPenyewaan.RowHeadersWidth = 62;
            dataGridPenyewaan.Size = new Size(511, 303);
            dataGridPenyewaan.TabIndex = 0;
            // 
            // cmbMetodePembayaran
            // 
            cmbMetodePembayaran.FormattingEnabled = true;
            cmbMetodePembayaran.Location = new Point(576, 156);
            cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            cmbMetodePembayaran.Size = new Size(182, 33);
            cmbMetodePembayaran.TabIndex = 1;
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.Location = new Point(576, 104);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(182, 31);
            txtTotalHarga.TabIndex = 2;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(608, 279);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(112, 34);
            btnBayar.TabIndex = 3;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // DashboardPembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBayar);
            Controls.Add(txtTotalHarga);
            Controls.Add(cmbMetodePembayaran);
            Controls.Add(dataGridPenyewaan);
            Name = "DashboardPembayaran";
            Text = "DashboardPembayaran";
            ((System.ComponentModel.ISupportInitialize)dataGridPenyewaan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPenyewaan;
        private ComboBox cmbMetodePembayaran;
        private TextBox txtTotalHarga;
        private Button btnBayar;
    }
}