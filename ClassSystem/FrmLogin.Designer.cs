namespace ClassSystem
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new WindowsFormsAero.CommandLink();
            this.UserText = new WindowsFormsAero.TextBox();
            this.PassText = new WindowsFormsAero.TextBox();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoginBtn.Location = new System.Drawing.Point(180, 307);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Note = "Waiting";
            this.LoginBtn.Size = new System.Drawing.Size(141, 56);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login System";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UserText
            // 
            this.UserText.CueBannerText = "User Name";
            this.UserText.Location = new System.Drawing.Point(142, 198);
            this.UserText.Name = "UserText";
            this.UserText.ShowCueFocused = true;
            this.UserText.Size = new System.Drawing.Size(183, 23);
            this.UserText.TabIndex = 0;
            // 
            // PassText
            // 
            this.PassText.CueBannerText = "Pass Word";
            this.PassText.Location = new System.Drawing.Point(142, 244);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(183, 23);
            this.PassText.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Training.Properties.Resources.QQ截图20161002132637;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(337, 371);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Selection System";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmLogin_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsAero.CommandLink LoginBtn;
        private WindowsFormsAero.TextBox UserText;
        private WindowsFormsAero.TextBox PassText;
    }
}

