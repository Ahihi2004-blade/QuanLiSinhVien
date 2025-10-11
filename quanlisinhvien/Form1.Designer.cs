namespace quanlisinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnsignin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblusername.Location = new System.Drawing.Point(105, 158);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(70, 16);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(209, 158);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(205, 22);
            this.txtusername.TabIndex = 1;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblpassword.Location = new System.Drawing.Point(105, 223);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(209, 220);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(205, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.SystemColors.Info;
            this.btnsignin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsignin.Location = new System.Drawing.Point(226, 278);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(75, 23);
            this.btnsignin.TabIndex = 2;
            this.btnsignin.Text = "Sign in";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Info;
            this.btncancel.Location = new System.Drawing.Point(339, 278);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Name = "Form1";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
    }
}

