namespace MetehanTopac_DersBilgileri
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbHafiza = new System.Windows.Forms.RadioButton();
            this.rbDosya = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nudKredi = new System.Windows.Forms.NumericUpDown();
            this.tbIcerik = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // rbHafiza
            // 
            this.rbHafiza.AutoSize = true;
            this.rbHafiza.Checked = true;
            this.rbHafiza.Location = new System.Drawing.Point(252, 304);
            this.rbHafiza.Name = "rbHafiza";
            this.rbHafiza.Size = new System.Drawing.Size(55, 17);
            this.rbHafiza.TabIndex = 1;
            this.rbHafiza.TabStop = true;
            this.rbHafiza.Text = "Hafıza";
            this.rbHafiza.UseVisualStyleBackColor = true;
            this.rbHafiza.CheckedChanged += new System.EventHandler(this.rbHafiza_CheckedChanged);
            // 
            // rbDosya
            // 
            this.rbDosya.AutoSize = true;
            this.rbDosya.Location = new System.Drawing.Point(313, 304);
            this.rbDosya.Name = "rbDosya";
            this.rbDosya.Size = new System.Drawing.Size(55, 17);
            this.rbDosya.TabIndex = 2;
            this.rbDosya.Text = "Dosya";
            this.rbDosya.UseVisualStyleBackColor = true;
            this.rbDosya.CheckedChanged += new System.EventHandler(this.rbDosya_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nudKredi);
            this.groupBox1.Controls.Add(this.tbIcerik);
            this.groupBox1.Controls.Add(this.cbKategori);
            this.groupBox1.Controls.Add(this.tbAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(595, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ders Ekle";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudKredi
            // 
            this.nudKredi.Location = new System.Drawing.Point(85, 129);
            this.nudKredi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKredi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKredi.Name = "nudKredi";
            this.nudKredi.Size = new System.Drawing.Size(35, 24);
            this.nudKredi.TabIndex = 7;
            this.nudKredi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbIcerik
            // 
            this.tbIcerik.Location = new System.Drawing.Point(85, 101);
            this.tbIcerik.Name = "tbIcerik";
            this.tbIcerik.Size = new System.Drawing.Size(175, 24);
            this.tbIcerik.TabIndex = 6;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(85, 69);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(175, 26);
            this.cbKategori.TabIndex = 5;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(85, 39);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(175, 24);
            this.tbAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kredisi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "İçeriği: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorisi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Yeni Öğrenci Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDosya);
            this.Controls.Add(this.rbHafiza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbHafiza;
        private System.Windows.Forms.RadioButton rbDosya;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudKredi;
        private System.Windows.Forms.TextBox tbIcerik;
        private System.Windows.Forms.Button button2;
    }
}

