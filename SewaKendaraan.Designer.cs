namespace Project_PBO
{
    partial class SewaKendaraan
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
            btnKonfirmasi = new Button();
            dataGridMobil = new DataGridView();
            datePeminjaman = new DateTimePicker();
            txtMerek = new TextBox();
            dataGridSupir = new DataGridView();
            txtTipe = new TextBox();
            txtKapasitas = new TextBox();
            txtHarga = new TextBox();
            txtStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTotalHarga = new TextBox();
            label7 = new Label();
            label8 = new Label();
            numDurasi = new NumericUpDown();
            label9 = new Label();
            datePengembalian = new DateTimePicker();
            label4 = new Label();
            checkSupir = new CheckBox();
            btnKembali = new Button();
            txtNamaSupir = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridMobil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSupir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDurasi).BeginInit();
            SuspendLayout();
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(777, 583);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(109, 31);
            btnKonfirmasi.TabIndex = 1;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click_1;
            // 
            // dataGridMobil
            // 
            dataGridMobil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMobil.Location = new Point(639, 12);
            dataGridMobil.Name = "dataGridMobil";
            dataGridMobil.RowHeadersWidth = 62;
            dataGridMobil.Size = new Size(486, 225);
            dataGridMobil.TabIndex = 2;
            dataGridMobil.CellClick += dataGridMobil_CellClick;
            dataGridMobil.CellContentClick += dataGridMobil_CellContentClick;
            // 
            // datePeminjaman
            // 
            datePeminjaman.Location = new Point(437, 481);
            datePeminjaman.Name = "datePeminjaman";
            datePeminjaman.Size = new Size(289, 31);
            datePeminjaman.TabIndex = 3;
            datePeminjaman.ValueChanged += datePeminjaman_ValueChanged;
            // 
            // txtMerek
            // 
            txtMerek.Enabled = false;
            txtMerek.Location = new Point(12, 22);
            txtMerek.Name = "txtMerek";
            txtMerek.Size = new Size(213, 31);
            txtMerek.TabIndex = 4;
            // 
            // dataGridSupir
            // 
            dataGridSupir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSupir.Location = new Point(639, 258);
            dataGridSupir.Name = "dataGridSupir";
            dataGridSupir.RowHeadersWidth = 62;
            dataGridSupir.Size = new Size(486, 134);
            dataGridSupir.TabIndex = 5;
            dataGridSupir.CellClick += dataGridSupir_CellClick;
            dataGridSupir.CellContentClick += dataGridView2_CellContentClick;
            // 
            // txtTipe
            // 
            txtTipe.Enabled = false;
            txtTipe.Location = new Point(12, 71);
            txtTipe.Name = "txtTipe";
            txtTipe.Size = new Size(213, 31);
            txtTipe.TabIndex = 6;
            // 
            // txtKapasitas
            // 
            txtKapasitas.Enabled = false;
            txtKapasitas.Location = new Point(12, 119);
            txtKapasitas.Name = "txtKapasitas";
            txtKapasitas.Size = new Size(213, 31);
            txtKapasitas.TabIndex = 7;
            // 
            // txtHarga
            // 
            txtHarga.Enabled = false;
            txtHarga.Location = new Point(12, 168);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(213, 31);
            txtHarga.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(12, 217);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(213, 31);
            txtStatus.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 42);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 10;
            label1.Text = "Merek Mobil";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 91);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 11;
            label2.Text = "Tipe Mobil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 135);
            label3.Name = "label3";
            label3.Size = new Size(186, 25);
            label3.TabIndex = 12;
            label3.Text = "Kapasitas Penumpang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 223);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 14;
            label5.Text = "Status Ketersediaan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(500, 515);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 15;
            label6.Text = "Tanggal Peminjaman";
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.Enabled = false;
            txtTotalHarga.Location = new Point(14, 361);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(213, 31);
            txtTotalHarga.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 275);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(247, 361);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 19;
            label8.Text = "Total Harga";
            // 
            // numDurasi
            // 
            numDurasi.Location = new Point(14, 321);
            numDurasi.Name = "numDurasi";
            numDurasi.Size = new Size(213, 31);
            numDurasi.TabIndex = 20;
            numDurasi.ValueChanged += numDurasi_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(253, 323);
            label9.Name = "label9";
            label9.Size = new Size(165, 25);
            label9.TabIndex = 21;
            label9.Text = "Durasi peminjaman";
            // 
            // datePengembalian
            // 
            datePengembalian.Location = new Point(777, 481);
            datePengembalian.Name = "datePengembalian";
            datePengembalian.Size = new Size(289, 31);
            datePengembalian.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 174);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 23;
            label4.Text = "Harga";
            // 
            // checkSupir
            // 
            checkSupir.AutoSize = true;
            checkSupir.Location = new Point(12, 271);
            checkSupir.Name = "checkSupir";
            checkSupir.Size = new Size(146, 29);
            checkSupir.TabIndex = 24;
            checkSupir.Text = "Dengan Supir";
            checkSupir.UseVisualStyleBackColor = true;
            checkSupir.CheckedChanged += checkSupir_CheckedChanged_1;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(970, 583);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(109, 31);
            btnKembali.TabIndex = 25;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // txtNamaSupir
            // 
            txtNamaSupir.Enabled = false;
            txtNamaSupir.Location = new Point(253, 269);
            txtNamaSupir.Name = "txtNamaSupir";
            txtNamaSupir.Size = new Size(213, 31);
            txtNamaSupir.TabIndex = 26;
            txtNamaSupir.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 418);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 33);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(828, 515);
            label10.Name = "label10";
            label10.Size = new Size(189, 25);
            label10.TabIndex = 28;
            label10.Text = "Tanggal Pengembalian";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 421);
            label11.Name = "label11";
            label11.Size = new Size(176, 25);
            label11.TabIndex = 29;
            label11.Text = "Metode Pembayaran";
            // 
            // SewaKendaraan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 647);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(txtNamaSupir);
            Controls.Add(btnKembali);
            Controls.Add(checkSupir);
            Controls.Add(label4);
            Controls.Add(datePengembalian);
            Controls.Add(label9);
            Controls.Add(numDurasi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTotalHarga);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStatus);
            Controls.Add(txtHarga);
            Controls.Add(txtKapasitas);
            Controls.Add(txtTipe);
            Controls.Add(dataGridSupir);
            Controls.Add(txtMerek);
            Controls.Add(datePeminjaman);
            Controls.Add(dataGridMobil);
            Controls.Add(btnKonfirmasi);
            Name = "SewaKendaraan";
            Text = "SewaKendaraan";
            Load += SewaKendaraan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMobil).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSupir).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDurasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKonfirmasi;
        private DataGridView dataGridMobil;
        private DateTimePicker datePeminjaman;
        private TextBox txtMerek;
        private DataGridView dataGridSupir;
        private TextBox txtTipe;
        private TextBox txtKapasitas;
        private TextBox txtHarga;
        private TextBox txtStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtTotalHarga;
        private Label label7;
        private Label label8;
        private NumericUpDown numDurasi;
        private Label label9;
        private DateTimePicker datePengembalian;
        private Label label4;
        private CheckBox checkSupir;
        private Button btnKembali;
        private TextBox txtNamaSupir;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
    }
}