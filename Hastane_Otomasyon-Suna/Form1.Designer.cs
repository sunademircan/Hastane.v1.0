namespace Hastane_Otomasyon_Suna
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktiflerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akiflerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxBransGirisi = new System.Windows.Forms.ComboBox();
            this.dTpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevuDüzenle = new System.Windows.Forms.Button();
            this.btnAktif = new System.Windows.Forms.Button();
            this.btnDeaktif = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstwRandevu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblGeriSayım = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dillerToolStripMenuItem,
            this.randevuİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dillerToolStripMenuItem
            // 
            this.dillerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRToolStripMenuItem,
            this.enToolStripMenuItem});
            this.dillerToolStripMenuItem.Name = "dillerToolStripMenuItem";
            this.dillerToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dillerToolStripMenuItem.Text = "Diller";
            // 
            // tRToolStripMenuItem
            // 
            this.tRToolStripMenuItem.Checked = true;
            this.tRToolStripMenuItem.CheckOnClick = true;
            this.tRToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tRToolStripMenuItem.Name = "tRToolStripMenuItem";
            this.tRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tRToolStripMenuItem.Text = "TR";
            this.tRToolStripMenuItem.Click += new System.EventHandler(this.tRToolStripMenuItem_Click);
            // 
            // enToolStripMenuItem
            // 
            this.enToolStripMenuItem.CheckOnClick = true;
            this.enToolStripMenuItem.Name = "enToolStripMenuItem";
            this.enToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enToolStripMenuItem.Text = "En";
            this.enToolStripMenuItem.Click += new System.EventHandler(this.enToolStripMenuItem_Click);
            // 
            // randevuİşlemleriToolStripMenuItem
            // 
            this.randevuİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.randevuİşlemleriToolStripMenuItem.Name = "randevuİşlemleriToolStripMenuItem";
            this.randevuİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.randevuİşlemleriToolStripMenuItem.Text = "Randevu İşlemleri";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktiflerToolStripMenuItem,
            this.akiflerToolStripMenuItem});
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // deaktiflerToolStripMenuItem
            // 
            this.deaktiflerToolStripMenuItem.Name = "deaktiflerToolStripMenuItem";
            this.deaktiflerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deaktiflerToolStripMenuItem.Text = "Deaktifler";
            // 
            // akiflerToolStripMenuItem
            // 
            this.akiflerToolStripMenuItem.Name = "akiflerToolStripMenuItem";
            this.akiflerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.akiflerToolStripMenuItem.Text = "Akifler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(90, 27);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(90, 63);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(90, 96);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTpDogumTarihi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // dTpDogumTarihi
            // 
            this.dTpDogumTarihi.Location = new System.Drawing.Point(92, 130);
            this.dTpDogumTarihi.Name = "dTpDogumTarihi";
            this.dTpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dTpDogumTarihi.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxBransGirisi);
            this.groupBox2.Controls.Add(this.dTpRandevuTarihi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(324, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 137);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgileri";
            // 
            // cBoxBransGirisi
            // 
            this.cBoxBransGirisi.FormattingEnabled = true;
            this.cBoxBransGirisi.Items.AddRange(new object[] {
            "JİNEKOLOG",
            "DAHİLİYE",
            "ORTOPEDİ",
            "ONKOLOJİ",
            "PSİKİYATR",
            "NÖROLOJİ",
            "DERMOTOLOJİ",
            "KARDİYOLOJİ"});
            this.cBoxBransGirisi.Location = new System.Drawing.Point(104, 27);
            this.cBoxBransGirisi.Name = "cBoxBransGirisi";
            this.cBoxBransGirisi.Size = new System.Drawing.Size(129, 21);
            this.cBoxBransGirisi.TabIndex = 8;
            // 
            // dTpRandevuTarihi
            // 
            this.dTpRandevuTarihi.Location = new System.Drawing.Point(104, 60);
            this.dTpRandevuTarihi.Name = "dTpRandevuTarihi";
            this.dTpRandevuTarihi.Size = new System.Drawing.Size(230, 20);
            this.dTpRandevuTarihi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Randevu Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş Giriş :";
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Location = new System.Drawing.Point(12, 215);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(84, 23);
            this.btnRandevuEkle.TabIndex = 5;
            this.btnRandevuEkle.Text = "Randevu Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(118, 215);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuSil.TabIndex = 5;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevuDüzenle
            // 
            this.btnRandevuDüzenle.Location = new System.Drawing.Point(208, 215);
            this.btnRandevuDüzenle.Name = "btnRandevuDüzenle";
            this.btnRandevuDüzenle.Size = new System.Drawing.Size(110, 23);
            this.btnRandevuDüzenle.TabIndex = 5;
            this.btnRandevuDüzenle.Text = "Randevu Düzenle";
            this.btnRandevuDüzenle.UseVisualStyleBackColor = true;
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(428, 215);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(75, 23);
            this.btnAktif.TabIndex = 5;
            this.btnAktif.Text = "Aktif";
            this.btnAktif.UseVisualStyleBackColor = true;
            // 
            // btnDeaktif
            // 
            this.btnDeaktif.Location = new System.Drawing.Point(560, 215);
            this.btnDeaktif.Name = "btnDeaktif";
            this.btnDeaktif.Size = new System.Drawing.Size(75, 23);
            this.btnDeaktif.TabIndex = 5;
            this.btnDeaktif.Text = "Deaktif";
            this.btnDeaktif.UseVisualStyleBackColor = true;
            this.btnDeaktif.Click += new System.EventHandler(this.btnDeaktif_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Randevu Durumu :";
            // 
            // lstwRandevu
            // 
            this.lstwRandevu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstwRandevu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstwRandevu.FullRowSelect = true;
            this.lstwRandevu.Location = new System.Drawing.Point(12, 257);
            this.lstwRandevu.MultiSelect = false;
            this.lstwRandevu.Name = "lstwRandevu";
            this.lstwRandevu.Size = new System.Drawing.Size(826, 167);
            this.lstwRandevu.TabIndex = 6;
            this.lstwRandevu.UseCompatibleStateImageBehavior = false;
            this.lstwRandevu.View = System.Windows.Forms.View.Details;
            this.lstwRandevu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstwRandevu_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik No";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Branş Girişi";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doğum Tarihi";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Randevu Tarihi";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Randevu Durumu";
            // 
            // lblGeriSayım
            // 
            this.lblGeriSayım.AutoSize = true;
            this.lblGeriSayım.Location = new System.Drawing.Point(468, 180);
            this.lblGeriSayım.Name = "lblGeriSayım";
            this.lblGeriSayım.Size = new System.Drawing.Size(0, 13);
            this.lblGeriSayım.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 436);
            this.Controls.Add(this.lblGeriSayım);
            this.Controls.Add(this.lstwRandevu);
            this.Controls.Add(this.btnDeaktif);
            this.Controls.Add(this.btnAktif);
            this.Controls.Add(this.btnRandevuDüzenle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnRandevuEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "-Hastane Randevu Sistemi -";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dillerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTpDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dTpRandevuTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRandevuDüzenle;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.Button btnDeaktif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstwRandevu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblGeriSayım;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cBoxBransGirisi;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktiflerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akiflerToolStripMenuItem;
    }
}

