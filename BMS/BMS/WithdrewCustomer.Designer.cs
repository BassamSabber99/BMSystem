namespace BMS
{
    partial class WithdrewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrewCustomer));
            this.depocus = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.with = new System.Windows.Forms.Button();
            this.withmon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // depocus
            // 
            this.depocus.AutoSize = true;
            this.depocus.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depocus.Location = new System.Drawing.Point(339, 195);
            this.depocus.Name = "depocus";
            this.depocus.Size = new System.Drawing.Size(112, 26);
            this.depocus.TabIndex = 7;
            this.depocus.Text = "Withdraw ";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(144, 30);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // with
            // 
            this.with.BackColor = System.Drawing.Color.Black;
            this.with.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.with.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.with.ForeColor = System.Drawing.Color.White;
            this.with.Location = new System.Drawing.Point(454, 282);
            this.with.Name = "with";
            this.with.Size = new System.Drawing.Size(139, 39);
            this.with.TabIndex = 5;
            this.with.Text = "Withdrew";
            this.with.UseVisualStyleBackColor = false;
            this.with.Click += new System.EventHandler(this.with_Click);
            // 
            // withmon
            // 
            this.withmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.withmon.Location = new System.Drawing.Point(493, 201);
            this.withmon.Name = "withmon";
            this.withmon.Size = new System.Drawing.Size(186, 20);
            this.withmon.TabIndex = 4;
            this.withmon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.withmon_KeyPress_1);
            // 
            // WithdrewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.depocus);
            this.Controls.Add(this.back);
            this.Controls.Add(this.with);
            this.Controls.Add(this.withmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WithdrewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrewCustomer";
            this.Load += new System.EventHandler(this.WithdrewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depocus;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button with;
        private System.Windows.Forms.TextBox withmon;
    }
}