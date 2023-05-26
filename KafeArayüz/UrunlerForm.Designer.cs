namespace KafeArayüz
{
    partial class UrunlerForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txtUrunAd = new TextBox();
            btnEkle = new Button();
            nudBirimFiyat = new NumericUpDown();
            dgvUrunler = new DataGridView();
            btnIptal = new Button();
            btnDuzenle = new Button();
            UrunAd = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 100);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyat (₺)";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(34, 52);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(212, 23);
            txtUrunAd.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.AliceBlue;
            btnEkle.Location = new Point(611, 67);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(142, 52);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.DecimalPlaces = 2;
            nudBirimFiyat.Location = new Point(137, 96);
            nudBirimFiyat.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(64, 23);
            nudBirimFiyat.TabIndex = 4;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.BackgroundColor = SystemColors.ActiveCaption;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Columns.AddRange(new DataGridViewColumn[] { UrunAd, BirimFiyat });
            dgvUrunler.Location = new Point(34, 135);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(719, 534);
            dgvUrunler.TabIndex = 5;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.AliceBlue;
            btnIptal.Location = new Point(697, 685);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(56, 33);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "IPTAL";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Visible = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.AliceBlue;
            btnDuzenle.Location = new Point(571, 685);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(116, 33);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // UrunAd
            // 
            UrunAd.DataPropertyName = "UrunAd";
            UrunAd.HeaderText = "Ürün Adı";
            UrunAd.Name = "UrunAd";
            UrunAd.ReadOnly = true;
            // 
            // BirimFiyat
            // 
            BirimFiyat.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            BirimFiyat.DefaultCellStyle = dataGridViewCellStyle1;
            BirimFiyat.HeaderText = "BirimFiyat";
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.ReadOnly = true;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 730);
            Controls.Add(btnDuzenle);
            Controls.Add(btnIptal);
            Controls.Add(dgvUrunler);
            Controls.Add(nudBirimFiyat);
            Controls.Add(btnEkle);
            Controls.Add(txtUrunAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUrunAd;
        private Button btnEkle;
        private NumericUpDown nudBirimFiyat;
        private DataGridView dgvUrunler;
        private Button btnIptal;
        private Button btnDuzenle;
        private DataGridViewTextBoxColumn UrunAd;
        private DataGridViewTextBoxColumn BirimFiyat;
    }
}