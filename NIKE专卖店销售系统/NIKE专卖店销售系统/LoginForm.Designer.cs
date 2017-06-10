namespace NIKE专卖店销售系统
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_LoginPwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_loginID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_LoginPwd
            // 
            this.txt_LoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoginPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LoginPwd.Location = new System.Drawing.Point(418, 265);
            this.txt_LoginPwd.Name = "txt_LoginPwd";
            this.txt_LoginPwd.Size = new System.Drawing.Size(187, 19);
            this.txt_LoginPwd.TabIndex = 1;
            this.txt_LoginPwd.Text = "123456";
            this.txt_LoginPwd.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.Location = new System.Drawing.Point(414, 308);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 33);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_loginID
            // 
            this.txt_loginID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_loginID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_loginID.Location = new System.Drawing.Point(418, 214);
            this.txt_loginID.MaxLength = 11;
            this.txt_loginID.Name = "txt_loginID";
            this.txt_loginID.Size = new System.Drawing.Size(187, 19);
            this.txt_loginID.TabIndex = 0;
            this.txt_loginID.Text = "18907234552";
            this.txt_loginID.TextChanged += new System.EventHandler(this.txt_loginID_TextChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(970, 461);
            this.Controls.Add(this.txt_loginID);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_LoginPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIKE专卖店销售系统-登录窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_LoginPwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_loginID;

    }
}