namespace BMS
{
    partial class Withdrewacc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrewacc));
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mon = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.withdrew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.ActiveBorderThickness = 1;
            this.back.ActiveCornerRadius = 20;
            this.back.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.ActiveForecolor = System.Drawing.Color.White;
            this.back.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.ButtonText = "Back ";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.SeaGreen;
            this.back.IdleBorderThickness = 1;
            this.back.IdleCornerRadius = 20;
            this.back.IdleFillColor = System.Drawing.Color.Black;
            this.back.IdleForecolor = System.Drawing.Color.White;
            this.back.IdleLineColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(14, 14);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(188, 42);
            this.back.TabIndex = 4;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // mon
            // 
            this.mon.AutoSize = true;
            this.mon.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon.Location = new System.Drawing.Point(143, 265);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(176, 26);
            this.mon.TabIndex = 10;
            this.mon.Text = "Withdraw Money";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(364, 271);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(193, 20);
            this.txtmoney.TabIndex = 9;
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress_1);
            // 
            // withdrew
            // 
            this.withdrew.ActiveBorderThickness = 1;
            this.withdrew.ActiveCornerRadius = 20;
            this.withdrew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.withdrew.ActiveForecolor = System.Drawing.Color.White;
            this.withdrew.ActiveLineColor = System.Drawing.Color.White;
            this.withdrew.BackColor = System.Drawing.Color.White;
            this.withdrew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("withdrew.BackgroundImage")));
            this.withdrew.ButtonText = "Withdrew";
            this.withdrew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrew.ForeColor = System.Drawing.Color.SeaGreen;
            this.withdrew.IdleBorderThickness = 1;
            this.withdrew.IdleCornerRadius = 20;
            this.withdrew.IdleFillColor = System.Drawing.Color.Black;
            this.withdrew.IdleForecolor = System.Drawing.Color.White;
            this.withdrew.IdleLineColor = System.Drawing.Color.White;
            this.withdrew.Location = new System.Drawing.Point(658, 230);
            this.withdrew.Margin = new System.Windows.Forms.Padding(5);
            this.withdrew.Name = "withdrew";
            this.withdrew.Size = new System.Drawing.Size(170, 50);
            this.withdrew.TabIndex = 8;
            this.withdrew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.withdrew.Click += new System.EventHandler(this.withdrew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(364, 220);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 20);
            this.txtid.TabIndex = 6;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress_1);
            // 
            // Withdrewacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.mon);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.withdrew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Withdrewacc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrewacc";
            this.Load += new System.EventHandler(this.Withdrewacc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private System.Windows.Forms.Label mon;
        private System.Windows.Forms.TextBox txtmoney;
        private Bunifu.Framework.UI.BunifuThinButton2 withdrew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}