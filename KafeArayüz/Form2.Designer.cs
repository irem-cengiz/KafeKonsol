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
            comboBox1 = new ComboBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            UrunAd = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            Adet = new DataGridViewTextBoxColumn();
            TutarTL = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 1;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(191, 43);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(413, 38);
            button1.Name = "button1";
            button1.Size = new Size(92, 30);
            button1.TabIndex = 4;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(616, 17);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 5;
            label3.Text = "Masa No:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(616, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(78, 23);
            comboBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.AliceBlue;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(763, 38);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 7;
            button2.Text = "TAŞI";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(630, 398);
            button3.Name = "button3";
            button3.Size = new Size(117, 60);
            button3.TabIndex = 8;
            button3.Text = "SİPARİŞ AL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.LimeGreen;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(775, 398);
            button4.Name = "button4";
            button4.Size = new Size(117, 60);
            button4.TabIndex = 9;
            button4.Text = "ÖDEME AL";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(634, 464);
            button5.Name = "button5";
            button5.Size = new Size(258, 47);
            button5.TabIndex = 10;
            button5.Text = "ANASAYFAYA DÖN";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(616, 320);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 11;
            label4.Text = "Ödeme Tutarı:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UrunAd, BirimFiyat, Adet, TutarTL });
            dataGridView1.Location = new Point(27, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(559, 434);
            dataGridView1.TabIndex = 12;
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
            TutarTL.HeaderText = "TutarTl";
            TutarTL.Name = "TutarTL";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuBar;
            label5.Location = new Point(612, 77);
            label5.Name = "label5";
            label5.Size = new Size(280, 193);
            label5.TabIndex = 0;
            label5.Text = "00";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(751, 320);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 13;
            label6.Text = "₺0,00";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 552);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            MinimumSize = new Size(929, 591);
            Name = "SiparisForm";
            Text = "Sipariş";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UrunAd;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn Adet;
        private DataGridViewTextBoxColumn TutarTL;
        private Label label5;
        private Label label6;
    }
}