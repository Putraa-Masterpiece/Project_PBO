namespace Project_PBO
{
    partial class DataSupircs
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
            dataGridSupir = new DataGridView();
            txtNamaSupir = new TextBox();
            txtNoTelepon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSupir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Kelola Supir";
            // 
            // dataGridSupir
            // 
            dataGridSupir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSupir.Location = new Point(12, 58);
            dataGridSupir.Name = "dataGridSupir";
            dataGridSupir.RowHeadersWidth = 62;
            dataGridSupir.Size = new Size(360, 225);
            dataGridSupir.TabIndex = 1;
            dataGridSupir.CellClick += dataGridSupir_CellClick;
            dataGridSupir.CellContentClick += dataGridSupir_CellContentClick;
            // 
            // txtNamaSupir
            // 
            txtNamaSupir.Location = new Point(612, 64);
            txtNamaSupir.Name = "txtNamaSupir";
            txtNamaSupir.Size = new Size(150, 31);
            txtNamaSupir.TabIndex = 5;
            txtNamaSupir.TextChanged += txtNamaSupir_TextChanged;
            // 
            // txtNoTelepon
            // 
            txtNoTelepon.Location = new Point(612, 126);
            txtNoTelepon.Name = "txtNoTelepon";
            txtNoTelepon.Size = new Size(150, 31);
            txtNoTelepon.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 64);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 7;
            label2.Text = "Nama Supir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 129);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 8;
            label3.Text = "Nomer Supir";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(650, 342);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 17;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(514, 342);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(366, 342);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 15;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(222, 342);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // DataSupircs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNoTelepon);
            Controls.Add(txtNamaSupir);
            Controls.Add(dataGridSupir);
            Controls.Add(label1);
            Name = "DataSupircs";
            Text = "DataSupircs";
            Load += DataSupircs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSupir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridSupir;
        private TextBox txtNamaSupir;
        private TextBox txtNoTelepon;
        private Label label2;
        private Label label3;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnClear;
    }
}