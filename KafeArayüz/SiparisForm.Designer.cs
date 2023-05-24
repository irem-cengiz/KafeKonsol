namespace KafeArayüz
{
    partial class SiparisForm
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
            cboUrun = new ComboBox();
            label2 = new Label();
            nudAdet = new NumericUpDown();
            btnEkle = new Button();
            label3 = new Label();
            cboMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            btnIptal = new Button();
            btnOdemeAl = new Button();
            btnAnasayfayaDon = new Button();
            label4 = new Label();
            dgvDetaylar = new DataGridView();
            Ürün = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            Adet = new DataGridViewTextBoxColumn();
            TutarTL = new DataGridViewTextBoxColumn();
            lblMasaNo = new Label();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 17);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(28, 43);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(147, 23);
            cboUrun.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 17);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 2;
            label2.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(191, 43);
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(53, 23);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.AliceBlue;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(494, 41);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(92, 30);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(612, 17);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 5;
            label3.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(612, 46);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(78, 23);
            cboMasaNo.TabIndex = 6;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.BackColor = Color.AliceBlue;
            btnMasaTasi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaTasi.Location = new Point(797, 37);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(95, 32);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIptal.BackColor = Color.Crimson;
            btnIptal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.Location = new Point(616, 398);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(117, 60);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "SİPARİŞ İPTAL";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.LimeGreen;
            btnOdemeAl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeAl.Location = new Point(770, 398);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(122, 60);
            btnOdemeAl.TabIndex = 9;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.AliceBlue;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfayaDon.Location = new Point(616, 464);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(276, 47);
            btnAnasayfayaDon.TabIndex = 10;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            btnAnasayfayaDon.Click += btnAnasayfayaDon_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(617, 300);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 11;
            label4.Text = "Ödeme Tutarı:";
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.BackgroundColor = SystemColors.ActiveCaption;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Ürün, BirimFiyat, Adet, TutarTL });
            dgvDetaylar.Location = new Point(27, 77);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(559, 434);
            dgvDetaylar.TabIndex = 12;
            // 
            // Ürün
            // 
            Ürün.DataPropertyName = "UrunAd";
            Ürün.HeaderText = "UrunAd";
            Ürün.Name = "Ürün";
            Ürün.ReadOnly = true;
            // 
            // BirimFiyat
            // 
            BirimFiyat.DataPropertyName = "BirimFiyat";
            BirimFiyat.HeaderText = "BirimFiyat";
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.ReadOnly = true;
            // 
            // Adet
            // 
            Adet.DataPropertyName = "Adet";
            Adet.HeaderText = "Adet";
            Adet.Name = "Adet";
            Adet.ReadOnly = true;
            // 
            // TutarTL
            // 
            TutarTL.DataPropertyName = "TutarTL";
            TutarTL.HeaderText = "TutarTl";
            TutarTL.Name = "TutarTL";
            TutarTL.ReadOnly = true;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Blue;
            lblMasaNo.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.MenuBar;
            lblMasaNo.Location = new Point(612, 77);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(280, 193);
            lblMasaNo.TabIndex = 0;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(752, 300);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(44, 20);
            lblOdemeTutari.TabIndex = 13;
            lblOdemeTutari.Text = "₺0,00";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 552);
            Controls.Add(lblOdemeTutari);
            Controls.Add(lblMasaNo);
            Controls.Add(dgvDetaylar);
            Controls.Add(label4);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnIptal);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(nudAdet);
            Controls.Add(label2);
            Controls.Add(cboUrun);
            Controls.Add(label1);
            MinimumSize = new Size(929, 591);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboUrun;
        private Label label2;
        private NumericUpDown nudAdet;
        private Button btnEkle;
        private Label label3;
        private ComboBox cboMasaNo;
        private Button btnMasaTasi;
        private Button btnIptal;
        private Button btnOdemeAl;
        private Button btnAnasayfayaDon;
        private Label label4;
        private DataGridView dgvDetaylar;
        private Label lblMasaNo;
        private Label lblOdemeTutari;
        private DataGridViewTextBoxColumn Ürün;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn Adet;
        private DataGridViewTextBoxColumn TutarTL;
    }
}