namespace QuanLyQuanCaPhe
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassBefor = new System.Windows.Forms.TextBox();
            this.textBoxPassRepeat = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu cũ";
            // 
            // textBoxPassAfter
            // 
            this.textBoxPassAfter.Location = new System.Drawing.Point(200, 30);
            this.textBoxPassAfter.Name = "textBoxPassAfter";
            this.textBoxPassAfter.Size = new System.Drawing.Size(128, 20);
            this.textBoxPassAfter.TabIndex = 1;
            this.textBoxPassAfter.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập lại";
            // 
            // textBoxPassBefor
            // 
            this.textBoxPassBefor.Location = new System.Drawing.Point(200, 67);
            this.textBoxPassBefor.Name = "textBoxPassBefor";
            this.textBoxPassBefor.Size = new System.Drawing.Size(128, 20);
            this.textBoxPassBefor.TabIndex = 4;
            this.textBoxPassBefor.UseSystemPasswordChar = true;
            // 
            // textBoxPassRepeat
            // 
            this.textBoxPassRepeat.Location = new System.Drawing.Point(200, 106);
            this.textBoxPassRepeat.Name = "textBoxPassRepeat";
            this.textBoxPassRepeat.Size = new System.Drawing.Size(128, 20);
            this.textBoxPassRepeat.TabIndex = 5;
            this.textBoxPassRepeat.UseSystemPasswordChar = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(275, 147);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(78, 23);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Đổi";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(169, 147);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(453, 182);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxPassRepeat);
            this.Controls.Add(this.textBoxPassBefor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassAfter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassBefor;
        private System.Windows.Forms.TextBox textBoxPassRepeat;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonCancel;
    }
}