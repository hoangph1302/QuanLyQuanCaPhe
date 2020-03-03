namespace QuanLyQuanCaPhe
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRepeatPass = new System.Windows.Forms.TextBox();
            this.buttonWatchPass = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxRepeatPass);
            this.panel1.Controls.Add(this.buttonWatchPass);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.textBoxDisplayName);
            this.panel1.Location = new System.Drawing.Point(136, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 275);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nhập lại MK";
            // 
            // textBoxRepeatPass
            // 
            this.textBoxRepeatPass.Location = new System.Drawing.Point(178, 177);
            this.textBoxRepeatPass.Name = "textBoxRepeatPass";
            this.textBoxRepeatPass.Size = new System.Drawing.Size(136, 20);
            this.textBoxRepeatPass.TabIndex = 34;
            this.textBoxRepeatPass.UseSystemPasswordChar = true;
            // 
            // buttonWatchPass
            // 
            this.buttonWatchPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWatchPass.BackgroundImage")));
            this.buttonWatchPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWatchPass.Location = new System.Drawing.Point(337, 137);
            this.buttonWatchPass.Name = "buttonWatchPass";
            this.buttonWatchPass.Size = new System.Drawing.Size(31, 21);
            this.buttonWatchPass.TabIndex = 33;
            this.buttonWatchPass.Text = ".";
            this.buttonWatchPass.UseVisualStyleBackColor = true;
            this.buttonWatchPass.Click += new System.EventHandler(this.buttonWatchPass_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tên đăng nhập";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(178, 95);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(136, 20);
            this.textBoxUserName.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mật khẩu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tên hiển thị";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(178, 137);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(136, 20);
            this.textBoxPass.TabIndex = 28;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Location = new System.Drawing.Point(178, 57);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(136, 20);
            this.textBoxDisplayName.TabIndex = 27;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(239, 219);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 36;
            this.buttonSignUp.Text = "Đăng Ký";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(141, 219);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 37;
            this.buttonExit.Text = "Hủy";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // SignUp
            // 
            this.AcceptButton = this.buttonSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxRepeatPass;
        private System.Windows.Forms.Button buttonWatchPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSignUp;
    }
}