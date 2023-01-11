namespace Yabancı_Dil_Yönetim_Sistemi
{
    partial class OgretmenYonetim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.labelGeri = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.FilterTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YonetimDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AlanTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ResimTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonResimSecme = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AdresTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CinsiyetCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DogumTarihiDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TelefonTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdSoyadTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YonetimDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGüncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGüncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGüncelle.Location = new System.Drawing.Point(731, 596);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(158, 36);
            this.buttonGüncelle.TabIndex = 50;
            this.buttonGüncelle.Text = "GÜNCELLE";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.Location = new System.Drawing.Point(895, 596);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(158, 36);
            this.buttonSil.TabIndex = 49;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTemizle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemizle.ForeColor = System.Drawing.Color.White;
            this.buttonTemizle.Location = new System.Drawing.Point(567, 596);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(158, 36);
            this.buttonTemizle.TabIndex = 48;
            this.buttonTemizle.Text = "TEMİZLE";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // labelGeri
            // 
            this.labelGeri.AutoSize = true;
            this.labelGeri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeri.ForeColor = System.Drawing.Color.White;
            this.labelGeri.Location = new System.Drawing.Point(12, 18);
            this.labelGeri.Name = "labelGeri";
            this.labelGeri.Size = new System.Drawing.Size(46, 23);
            this.labelGeri.TabIndex = 36;
            this.labelGeri.Text = "<<<";
            this.labelGeri.Click += new System.EventHandler(this.labelGeri_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAra.ForeColor = System.Drawing.Color.White;
            this.buttonAra.Location = new System.Drawing.Point(971, 16);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(70, 36);
            this.buttonAra.TabIndex = 34;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYenile.ForeColor = System.Drawing.Color.White;
            this.buttonYenile.Location = new System.Drawing.Point(1047, 16);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(88, 36);
            this.buttonYenile.TabIndex = 32;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = false;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // FilterTb
            // 
            this.FilterTb.Location = new System.Drawing.Point(763, 28);
            this.FilterTb.Name = "FilterTb";
            this.FilterTb.Size = new System.Drawing.Size(185, 22);
            this.FilterTb.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(439, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğretmen Yönetim";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.labelGeri);
            this.panel1.Controls.Add(this.buttonAra);
            this.panel1.Controls.Add(this.buttonYenile);
            this.panel1.Controls.Add(this.FilterTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 66);
            this.panel1.TabIndex = 36;
            // 
            // YonetimDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.YonetimDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.YonetimDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.YonetimDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YonetimDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.YonetimDGV.ColumnHeadersHeight = 24;
            this.YonetimDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.YonetimDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.YonetimDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.YonetimDGV.Location = new System.Drawing.Point(0, 72);
            this.YonetimDGV.Name = "YonetimDGV";
            this.YonetimDGV.ReadOnly = true;
            this.YonetimDGV.RowHeadersVisible = false;
            this.YonetimDGV.RowHeadersWidth = 51;
            this.YonetimDGV.RowTemplate.Height = 24;
            this.YonetimDGV.Size = new System.Drawing.Size(1146, 266);
            this.YonetimDGV.TabIndex = 52;
            this.YonetimDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.YonetimDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.YonetimDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.YonetimDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.YonetimDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.YonetimDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.YonetimDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.YonetimDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.YonetimDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.YonetimDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YonetimDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.YonetimDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.YonetimDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.YonetimDGV.ThemeStyle.ReadOnly = true;
            this.YonetimDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.YonetimDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.YonetimDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YonetimDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.YonetimDGV.ThemeStyle.RowsStyle.Height = 24;
            this.YonetimDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YonetimDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.YonetimDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YonetimDGV_CellClick);
            // 
            // AlanTb
            // 
            this.AlanTb.Location = new System.Drawing.Point(562, 348);
            this.AlanTb.Name = "AlanTb";
            this.AlanTb.Size = new System.Drawing.Size(185, 22);
            this.AlanTb.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(474, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 86;
            this.label9.Text = "Alanı:";
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(181, 570);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(185, 22);
            this.EmailTb.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(93, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 84;
            this.label10.Text = "Email:";
            // 
            // ResimTb
            // 
            this.ResimTb.Location = new System.Drawing.Point(562, 516);
            this.ResimTb.Name = "ResimTb";
            this.ResimTb.Size = new System.Drawing.Size(185, 22);
            this.ResimTb.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(468, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 82;
            this.label8.Text = "Resim:";
            // 
            // buttonResimSecme
            // 
            this.buttonResimSecme.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResimSecme.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResimSecme.ForeColor = System.Drawing.Color.White;
            this.buttonResimSecme.Location = new System.Drawing.Point(753, 517);
            this.buttonResimSecme.Name = "buttonResimSecme";
            this.buttonResimSecme.Size = new System.Drawing.Size(58, 22);
            this.buttonResimSecme.TabIndex = 81;
            this.buttonResimSecme.Text = "...";
            this.buttonResimSecme.UseVisualStyleBackColor = false;
            this.buttonResimSecme.Click += new System.EventHandler(this.buttonResimSecme_Click_1);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(860, 348);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(219, 188);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 80;
            this.PictureBox.TabStop = false;
            // 
            // AdresTb
            // 
            this.AdresTb.Location = new System.Drawing.Point(562, 405);
            this.AdresTb.Multiline = true;
            this.AdresTb.Name = "AdresTb";
            this.AdresTb.Size = new System.Drawing.Size(185, 81);
            this.AdresTb.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(470, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Adres:";
            // 
            // CinsiyetCb
            // 
            this.CinsiyetCb.FormattingEnabled = true;
            this.CinsiyetCb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CinsiyetCb.Location = new System.Drawing.Point(181, 402);
            this.CinsiyetCb.Name = "CinsiyetCb";
            this.CinsiyetCb.Size = new System.Drawing.Size(185, 24);
            this.CinsiyetCb.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(67, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cinsiyet:";
            // 
            // DogumTarihiDTP
            // 
            this.DogumTarihiDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DogumTarihiDTP.Location = new System.Drawing.Point(181, 461);
            this.DogumTarihiDTP.Name = "DogumTarihiDTP";
            this.DogumTarihiDTP.Size = new System.Drawing.Size(185, 22);
            this.DogumTarihiDTP.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(24, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Doğum Tarih:";
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(181, 517);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.Size = new System.Drawing.Size(185, 22);
            this.TelefonTb.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(75, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Telefon:";
            // 
            // AdSoyadTb
            // 
            this.AdSoyadTb.Location = new System.Drawing.Point(181, 348);
            this.AdSoyadTb.Name = "AdSoyadTb";
            this.AdSoyadTb.Size = new System.Drawing.Size(185, 22);
            this.AdSoyadTb.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(50, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ad Soyad:";
            // 
            // OgretmenYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 639);
            this.Controls.Add(this.AlanTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResimTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonResimSecme);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.AdresTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CinsiyetCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DogumTarihiDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefonTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdSoyadTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YonetimDGV);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgretmenYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OgretmenYonetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YonetimDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label labelGeri;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.TextBox FilterTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView YonetimDGV;
        private System.Windows.Forms.TextBox AlanTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ResimTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonResimSecme;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox AdresTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CinsiyetCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DogumTarihiDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelefonTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdSoyadTb;
        private System.Windows.Forms.Label label1;
    }
}