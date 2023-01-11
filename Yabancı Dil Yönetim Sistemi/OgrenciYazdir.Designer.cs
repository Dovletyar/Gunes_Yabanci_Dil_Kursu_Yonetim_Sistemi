namespace Yabancı_Dil_Yönetim_Sistemi
{
    partial class OgrenciYazdir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciYazdir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FilterTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrenciListesiYazdir = new System.Windows.Forms.Button();
            this.YazdirDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.OgrenciListesiPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.OgrenciYazdirPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YazdirDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.FilterTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 66);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "<<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOrange;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(971, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 36);
            this.button6.TabIndex = 34;
            this.button6.Text = "Ara";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1047, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 36);
            this.button5.TabIndex = 32;
            this.button5.Text = "Yenile";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.label6.Location = new System.Drawing.Point(457, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğrenci Listesi";
            // 
            // ogrenciListesiYazdir
            // 
            this.ogrenciListesiYazdir.BackColor = System.Drawing.Color.DarkCyan;
            this.ogrenciListesiYazdir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciListesiYazdir.ForeColor = System.Drawing.Color.White;
            this.ogrenciListesiYazdir.Location = new System.Drawing.Point(920, 582);
            this.ogrenciListesiYazdir.Name = "ogrenciListesiYazdir";
            this.ogrenciListesiYazdir.Size = new System.Drawing.Size(158, 36);
            this.ogrenciListesiYazdir.TabIndex = 31;
            this.ogrenciListesiYazdir.Text = "YAZDIR";
            this.ogrenciListesiYazdir.UseVisualStyleBackColor = false;
            this.ogrenciListesiYazdir.Click += new System.EventHandler(this.button3_Click);
            // 
            // YazdirDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.YazdirDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.YazdirDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YazdirDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.YazdirDGV.ColumnHeadersHeight = 24;
            this.YazdirDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.YazdirDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.YazdirDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.YazdirDGV.Location = new System.Drawing.Point(0, 58);
            this.YazdirDGV.Name = "YazdirDGV";
            this.YazdirDGV.ReadOnly = true;
            this.YazdirDGV.RowHeadersVisible = false;
            this.YazdirDGV.RowHeadersWidth = 51;
            this.YazdirDGV.RowTemplate.Height = 24;
            this.YazdirDGV.Size = new System.Drawing.Size(1146, 511);
            this.YazdirDGV.TabIndex = 36;
            this.YazdirDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.YazdirDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.YazdirDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.YazdirDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.YazdirDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.YazdirDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.YazdirDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.YazdirDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.YazdirDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.YazdirDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YazdirDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.YazdirDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.YazdirDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.YazdirDGV.ThemeStyle.ReadOnly = true;
            this.YazdirDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.YazdirDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.YazdirDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YazdirDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.YazdirDGV.ThemeStyle.RowsStyle.Height = 24;
            this.YazdirDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YazdirDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.YazdirDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YazdirDGV_CellContentClick);
            // 
            // OgrenciListesiPrintPreviewDialog
            // 
            this.OgrenciListesiPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.OgrenciListesiPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.OgrenciListesiPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.OgrenciListesiPrintPreviewDialog.Enabled = true;
            this.OgrenciListesiPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("OgrenciListesiPrintPreviewDialog.Icon")));
            this.OgrenciListesiPrintPreviewDialog.Name = "OgrenciListesiPrintPreviewDialog";
            this.OgrenciListesiPrintPreviewDialog.Visible = false;
            // 
            // OgrenciYazdirPrintDocument
            // 
            this.OgrenciYazdirPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OgrenciYazdirPrintDocument_PrintPage);
            // 
            // OgrenciYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 639);
            this.Controls.Add(this.YazdirDGV);
            this.Controls.Add(this.ogrenciListesiYazdir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgrenciYazdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OgrenciYazdir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YazdirDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox FilterTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ogrenciListesiYazdir;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView YazdirDGV;
        private System.Windows.Forms.PrintPreviewDialog OgrenciListesiPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument OgrenciYazdirPrintDocument;
    }
}