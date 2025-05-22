namespace Project_PBO
{
    partial class KelolaKendaraan
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
            txtMerek = new TextBox();
            dataGridKendaraan = new DataGridView();
            txtTipe = new TextBox();
            txtHarga = new TextBox();
            numKapasitas = new NumericUpDown();
            comboStatus = new ComboBox();
            btnClear = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnSimpan = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridKendaraan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKapasitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Kelola Kendaarn";
            label1.Click += label1_Click;
            // 
            // txtMerek
            // 
            txtMerek.Location = new Point(638, 48);
            txtMerek.Name = "txtMerek";
            txtMerek.Size = new Size(150, 31);
            txtMerek.TabIndex = 1;
            // 
            // dataGridKendaraan
            // 
            dataGridKendaraan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKendaraan.Location = new Point(23, 73);
            dataGridKendaraan.Name = "dataGridKendaraan";
            dataGridKendaraan.RowHeadersWidth = 62;
            dataGridKendaraan.Size = new Size(360, 225);
            dataGridKendaraan.TabIndex = 2;
            dataGridKendaraan.CellClick += dataGridKendaraan_CellClick;
            // 
            // txtTipe
            // 
            txtTipe.Location = new Point(638, 101);
            txtTipe.Name = "txtTipe";
            txtTipe.Size = new Size(150, 31);
            txtTipe.TabIndex = 3;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(638, 218);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(150, 31);
            txtHarga.TabIndex = 6;
            // 
            // numKapasitas
            // 
            numKapasitas.Location = new Point(638, 160);
            numKapasitas.Name = "numKapasitas";
            numKapasitas.Size = new Size(150, 31);
            numKapasitas.TabIndex = 8;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(638, 265);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(150, 33);
            comboStatus.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(392, 365);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(540, 365);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(676, 365);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 54);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 14;
            label2.Text = "Merek Mobil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 162);
            label3.Name = "label3";
            label3.Size = new Size(186, 25);
            label3.TabIndex = 15;
            label3.Text = "Kapasitas Penumpang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 107);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 16;
            label4.Text = "Tipe Mobil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 218);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 17;
            label5.Text = "Harga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 273);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 18;
            label6.Text = "Status Ketersediaan";
            // 
            // KelolaKendaraan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSimpan);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnClear);
            Controls.Add(comboStatus);
            Controls.Add(numKapasitas);
            Controls.Add(txtHarga);
            Controls.Add(txtTipe);
            Controls.Add(dataGridKendaraan);
            Controls.Add(txtMerek);
            Controls.Add(label1);
            Name = "KelolaKendaraan";
            Text = "KelolaKendaraan";
            Load += KelolaKendaraan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridKendaraan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKapasitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMerek;
        private DataGridView dataGridKendaraan;
        private TextBox txtTipe;
        private TextBox txtHarga;
        private NumericUpDown numKapasitas;
        private ComboBox comboStatus;
        private Button btnClear;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnSimpan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}