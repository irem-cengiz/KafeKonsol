namespace KafeArayüz
{
    partial class GecmisSiparislerForm
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
            MasaNo = new DataGridViewTextBoxColumn();
            AcilisZamani = new DataGridViewTextBoxColumn();
            Durum = new DataGridViewTextBoxColumn();
            OdenenTutar = new DataGridViewTextBoxColumn();
            ToplamTutarTL = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            UrunAd = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            Adet = new DataGridViewTextBoxColumn();
            TutarTL = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MasaNo, AcilisZamani, Durum, OdenenTutar, ToplamTutarTL });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(916, 292);
            dataGridView1.TabIndex = 0;
            // 
            // MasaNo
            // 
            MasaNo.HeaderText = "MasaNo";
            MasaNo.Name = "MasaNo";
            // 
            // AcilisZamani
            // 
            AcilisZamani.HeaderText = "AcilisZamani";
            AcilisZamani.Name = "AcilisZamani";
            // 
            // Durum
            // 
            Durum.HeaderText = "Durum";
            Durum.Name = "Durum";
            // 
            // OdenenTutar
            // 
            OdenenTutar.HeaderText = "OdenenTutar";
            OdenenTutar.Name = "OdenenTutar";
            // 
            // ToplamTutarTL
            // 
            ToplamTutarTL.HeaderText = "ToplamTutarTL";
            ToplamTutarTL.Name = "ToplamTutarTL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Siparişler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 2;
            label2.Text = "Sipariş Detayları";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { UrunAd, BirimFiyat, Adet, TutarTL });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 51);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(916, 283);
            dataGridView2.TabIndex = 3;
            // 
            // UrunAd
            // 
            UrunAd.HeaderText = "UrunAd";
            UrunAd.Name = "UrunAd";
            // 
            // BirimFiyat
            // 
            BirimFiyat.HeaderText = "BirimFiyat";
            BirimFiyat.Name = "BirimFiyat";
            // 
            // Adet
            // 
            Adet.HeaderText = "Adet";
            Adet.Name = "Adet";
            // 
            // TutarTL
            // 
            TutarTL.HeaderText = "TutarTL";
            TutarTL.Name = "TutarTL";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(24, 21);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(916, 673);
            splitContainer1.SplitterDistance = 335;
            splitContainer1.TabIndex = 4;
            // 
            // GecmisSiparislerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 741);
            Controls.Add(splitContainer1);
            Name = "GecmisSiparislerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Geçmiş Siparişler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MasaNo;
        private DataGridViewTextBoxColumn AcilisZamani;
        private DataGridViewTextBoxColumn Durum;
        private DataGridViewTextBoxColumn OdenenTutar;
        private DataGridViewTextBoxColumn ToplamTutarTL;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn UrunAd;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn Adet;
        private DataGridViewTextBoxColumn TutarTL;
        private SplitContainer splitContainer1;
    }
}