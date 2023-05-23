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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            UrunAd = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(248, 37);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyat (₺)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Location = new Point(454, 56);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 3;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(248, 69);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UrunAd, BirimFiyat });
            dataGridView1.Location = new Point(34, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(570, 379);
            dataGridView1.TabIndex = 5;
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
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 522);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UrunAd;
        private DataGridViewTextBoxColumn BirimFiyat;
    }
}