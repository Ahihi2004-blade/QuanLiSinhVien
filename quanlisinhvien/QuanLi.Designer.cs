namespace quanlisinhvien
{
    partial class QuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLi));
            this.btnqlsv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblgdqlsv = new System.Windows.Forms.Label();
            this.btnquanlidiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnqlsv
            // 
            this.btnqlsv.Location = new System.Drawing.Point(147, 200);
            this.btnqlsv.Name = "btnqlsv";
            this.btnqlsv.Size = new System.Drawing.Size(77, 68);
            this.btnqlsv.TabIndex = 0;
            this.btnqlsv.Text = "Quản Lí Sinh VIên";
            this.btnqlsv.UseVisualStyleBackColor = true;
            this.btnqlsv.Click += new System.EventHandler(this.btnqlsv_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản Lí Điểm Rèn Luyện";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblgdqlsv
            // 
            this.lblgdqlsv.AutoSize = true;
            this.lblgdqlsv.BackColor = System.Drawing.Color.Beige;
            this.lblgdqlsv.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblgdqlsv.Location = new System.Drawing.Point(111, 79);
            this.lblgdqlsv.Name = "lblgdqlsv";
            this.lblgdqlsv.Size = new System.Drawing.Size(602, 46);
            this.lblgdqlsv.TabIndex = 2;
            this.lblgdqlsv.Text = "GIAO DIỆN QUẢN LÍ SINH VIÊN";
            // 
            // btnquanlidiem
            // 
            this.btnquanlidiem.Location = new System.Drawing.Point(357, 200);
            this.btnquanlidiem.Name = "btnquanlidiem";
            this.btnquanlidiem.Size = new System.Drawing.Size(75, 70);
            this.btnquanlidiem.TabIndex = 3;
            this.btnquanlidiem.Text = "Quản Lí Điểm/GPA";
            this.btnquanlidiem.UseVisualStyleBackColor = true;
            this.btnquanlidiem.Click += new System.EventHandler(this.btnquanlidiem_Click);
            // 
            // QuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnquanlidiem);
            this.Controls.Add(this.lblgdqlsv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnqlsv);
            this.Name = "QuanLi";
            this.Text = "QuanLi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqlsv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblgdqlsv;
        private System.Windows.Forms.Button btnquanlidiem;
    }
}