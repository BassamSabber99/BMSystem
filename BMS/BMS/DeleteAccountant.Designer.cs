﻿namespace BMS
{
    partial class DeleteAccountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccountant));
            this.check = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labl = new System.Windows.Forms.Label();
            this.gridinfo = new System.Windows.Forms.DataGridView();
            this.id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.deletecus = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridinfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.ActiveBorderThickness = 1;
            this.check.ActiveCornerRadius = 20;
            this.check.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.check.ActiveForecolor = System.Drawing.Color.White;
            this.check.ActiveLineColor = System.Drawing.Color.Silver;
            this.check.BackColor = System.Drawing.Color.White;
            this.check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check.BackgroundImage")));
            this.check.ButtonText = "Check";
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.SeaGreen;
            this.check.IdleBorderThickness = 1;
            this.check.IdleCornerRadius = 20;
            this.check.IdleFillColor = System.Drawing.Color.Black;
            this.check.IdleForecolor = System.Drawing.Color.White;
            this.check.IdleLineColor = System.Drawing.Color.Black;
            this.check.Location = new System.Drawing.Point(174, 337);
            this.check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(146, 46);
            this.check.TabIndex = 11;
            this.check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Location = new System.Drawing.Point(44, 218);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(158, 26);
            this.labl.TabIndex = 9;
            this.labl.Text = "Accountant ID ";
            // 
            // gridinfo
            // 
            this.gridinfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridinfo.Location = new System.Drawing.Point(600, 135);
            this.gridinfo.Name = "gridinfo";
            this.gridinfo.Size = new System.Drawing.Size(330, 181);
            this.gridinfo.TabIndex = 8;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.BorderColorFocused = System.Drawing.Color.Transparent;
            this.id.BorderColorIdle = System.Drawing.Color.Transparent;
            this.id.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.BorderThickness = 1;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.isPassword = false;
            this.id.Location = new System.Drawing.Point(248, 218);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(235, 26);
            this.id.TabIndex = 7;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 39);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BMS.Properties.Resources.left_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(829, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.remove_button1;
            this.pictureBox1.Location = new System.Drawing.Point(887, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BMS.Properties.Resources.Bank_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // deletecus
            // 
            this.deletecus.ActiveBorderThickness = 1;
            this.deletecus.ActiveCornerRadius = 20;
            this.deletecus.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletecus.ActiveForecolor = System.Drawing.Color.Maroon;
            this.deletecus.ActiveLineColor = System.Drawing.Color.Silver;
            this.deletecus.BackColor = System.Drawing.Color.White;
            this.deletecus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletecus.BackgroundImage")));
            this.deletecus.ButtonText = "DELETE";
            this.deletecus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletecus.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecus.ForeColor = System.Drawing.Color.SeaGreen;
            this.deletecus.IdleBorderThickness = 1;
            this.deletecus.IdleCornerRadius = 20;
            this.deletecus.IdleFillColor = System.Drawing.Color.Black;
            this.deletecus.IdleForecolor = System.Drawing.Color.White;
            this.deletecus.IdleLineColor = System.Drawing.Color.Silver;
            this.deletecus.Location = new System.Drawing.Point(694, 337);
            this.deletecus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletecus.Name = "deletecus";
            this.deletecus.Size = new System.Drawing.Size(164, 51);
            this.deletecus.TabIndex = 10;
            this.deletecus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletecus.Click += new System.EventHandler(this.deletecus_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DeleteAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.check);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.gridinfo);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletecus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAccountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAccountant";
            this.Load += new System.EventHandler(this.DeleteAccountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridinfo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 check;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.DataGridView gridinfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 deletecus;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}