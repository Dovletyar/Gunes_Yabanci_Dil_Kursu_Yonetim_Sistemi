namespace Yabancı_Dil_Yönetim_Sistemi
{
    partial class OgretmenKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
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
            this.OgretmenDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AlanTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgretmenDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 66);
            this.panel1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "<<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::Yabancı_Dil_Yönetim_Sistemi.Properties.Resources.teacher_cartoon_pictures_pin_pinterest_pinsdaddy_27;
            this.pictureBox2.Location = new System.Drawing.Point(1004, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(454, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğretmen Kayıt";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.Location = new System.Drawing.Point(899, 593);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(158, 36);
            this.buttonEkle.TabIndex = 50;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTemizle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemizle.ForeColor = System.Drawing.Color.White;
            this.buttonTemizle.Location = new System.Drawing.Point(686, 593);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(158, 36);
            this.buttonTemizle.TabIndex = 49;
            this.buttonTemizle.Text = "TEMİZLE";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(188, 567);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(185, 22);
            this.EmailTb.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(100, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 66;
            this.label10.Text = "Email:";
            // 
            // ResimTb
            // 
            this.ResimTb.Location = new System.Drawing.Point(569, 513);
            this.ResimTb.Name = "ResimTb";
            this.ResimTb.Size = new System.Drawing.Size(185, 22);
            this.ResimTb.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(475, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Resim:";
            // 
            // buttonResimSecme
            // 
            this.buttonResimSecme.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResimSecme.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResimSecme.ForeColor = System.Drawing.Color.White;
            this.buttonResimSecme.Location = new System.Drawing.Point(760, 514);
            this.buttonResimSecme.Name = "buttonResimSecme";
            this.buttonResimSecme.Size = new System.Drawing.Size(58, 22);
            this.buttonResimSecme.TabIndex = 63;
            this.buttonResimSecme.Text = "...";
            this.buttonResimSecme.UseVisualStyleBackColor = false;
            this.buttonResimSecme.Click += new System.EventHandler(this.buttonResimSecme_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(867, 345);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(219, 188);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 62;
            this.PictureBox.TabStop = false;
            // 
            // AdresTb
            // 
            this.AdresTb.Location = new System.Drawing.Point(569, 402);
            this.AdresTb.Multiline = true;
            this.AdresTb.Name = "AdresTb";
            this.AdresTb.Size = new System.Drawing.Size(185, 81);
            this.AdresTb.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(477, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Adres:";
            // 
            // CinsiyetCb
            // 
            this.CinsiyetCb.FormattingEnabled = true;
            this.CinsiyetCb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CinsiyetCb.Location = new System.Drawing.Point(188, 399);
            this.CinsiyetCb.Name = "CinsiyetCb";
            this.CinsiyetCb.Size = new System.Drawing.Size(185, 24);
            this.CinsiyetCb.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(74, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Cinsiyet:";
            // 
            // DogumTarihiDTP
            // 
            this.DogumTarihiDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DogumTarihiDTP.Location = new System.Drawing.Point(188, 458);
            this.DogumTarihiDTP.Name = "DogumTarihiDTP";
            this.DogumTarihiDTP.Size = new System.Drawing.Size(185, 22);
            this.DogumTarihiDTP.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(31, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Doğum Tarih:";
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(188, 514);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.Size = new System.Drawing.Size(185, 22);
            this.TelefonTb.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(82, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Telefon:";
            // 
            // AdSoyadTb
            // 
            this.AdSoyadTb.Location = new System.Drawing.Point(188, 345);
            this.AdSoyadTb.Name = "AdSoyadTb";
            this.AdSoyadTb.Size = new System.Drawing.Size(185, 22);
            this.AdSoyadTb.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(57, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ad Soyad:";
            // 
            // OgretmenDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OgretmenDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OgretmenDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OgretmenDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OgretmenDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OgretmenDGV.ColumnHeadersHeight = 24;
            this.OgretmenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OgretmenDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.OgretmenDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OgretmenDGV.Location = new System.Drawing.Point(0, 72);
            this.OgretmenDGV.Name = "OgretmenDGV";
            this.OgretmenDGV.ReadOnly = true;
            this.OgretmenDGV.RowHeadersVisible = false;
            this.OgretmenDGV.RowHeadersWidth = 51;
            this.OgretmenDGV.RowTemplate.Height = 24;
            this.OgretmenDGV.Size = new System.Drawing.Size(1146, 258);
            this.OgretmenDGV.TabIndex = 51;
            this.OgretmenDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OgretmenDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OgretmenDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OgretmenDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OgretmenDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OgretmenDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OgretmenDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OgretmenDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OgretmenDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.OgretmenDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgretmenDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.OgretmenDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OgretmenDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.OgretmenDGV.ThemeStyle.ReadOnly = true;
            this.OgretmenDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OgretmenDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OgretmenDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgretmenDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OgretmenDGV.ThemeStyle.RowsStyle.Height = 24;
            this.OgretmenDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OgretmenDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AlanTb
            // 
            this.AlanTb.Location = new System.Drawing.Point(569, 345);
            this.AlanTb.Name = "AlanTb";
            this.AlanTb.Size = new System.Drawing.Size(185, 22);
            this.AlanTb.TabIndex = 69;
            this.AlanTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(481, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Alanı:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // OgretmenKayit
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
            this.Controls.Add(this.OgretmenDGV);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgretmenKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OgretmenKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgretmenDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonTemizle;
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
        private Guna.UI2.WinForms.Guna2DataGridView OgretmenDGV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox AlanTb;
        private System.Windows.Forms.Label label9;
    }
}