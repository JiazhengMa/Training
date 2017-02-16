using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassSystem.db;
using System.Drawing.Drawing2D;
using WindowsFormsAero.TaskDialog;

namespace ClassSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
           SetStyle(ControlStyles.UserPaint, true);
           SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.  
           SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲  
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int ret = Login.LoginCheck(this.UserText.Text, this.PassText.Text);
            if (ret == -1)
            {
                TaskDialog.Show("Login Error", "Reminder", "User does not exist or password error！", TaskDialogButton.OK, TaskDialogIcon.SecurityError);
                return;
            }
            else if (ret == 1)
            {
                TaskDialog.Show("Login Success", "Reminder", "Administrative authority！", TaskDialogButton.OK, TaskDialogIcon.SecuritySuccess);
                FrmAdmin fm = new FrmAdmin();
                fm.Text = "Welcome to the course selection system 【Administrator mode】";
                fm.Show();
            }
            else if (ret == 2)
            {
                TaskDialog.Show("Login Success", "Reminder", "Teacher authority！", TaskDialogButton.OK, TaskDialogIcon.SecuritySuccess);
                FrmTeacher fm = new FrmTeacher();
                fm.Text = "Welcome to the course selection system 【Teacher mode】";
                fm.Show();
            }
            else if (ret == 3)
            {
                TaskDialog.Show("Login Success", "Reminder", "Student authority！", TaskDialogButton.OK, TaskDialogIcon.SecuritySuccess);
                FrmStudent fm = new FrmStudent();
                fm.id = Login.GetID(this.UserText.Text, this.PassText.Text);
                fm.Text = "Welcome to the course selection system 【Student mode】";
                fm.Show(); 
            }
            this.Visible = false;
            return;
        }
        string Logostr = "Course Selection System";

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            StringFormat stringFormat = new StringFormat();
            stringFormat.FormatFlags = StringFormatFlags.NoWrap;
            stringFormat.Alignment = StringAlignment.Center;
            Font font = new Font("微软雅黑", 20, FontStyle.Regular);
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(0, 103, this.Width, this.Height - 105));
            e.Graphics.DrawString(Logostr, font, new LinearGradientBrush(new Rectangle(new Point(0, 0), GetStringL(Logostr, font)), Color.FromArgb(255, 172, 152), Color.FromArgb(206, 235, 147), LinearGradientMode.Horizontal), new Rectangle(0, 100, this.Width, 50), stringFormat);
            Brush brush = new LinearGradientBrush(new Rectangle(0, this.Height - 140, this.Width, 140), Color.FromArgb(1, Color.Black), Color.FromArgb(28, Color.Black), LinearGradientMode.Vertical);
            //e.Graphics.FillRectangle(brush, new Rectangle(0, this.Height - 140, this.Width, 140));
            e.Graphics.DrawImage(Image.FromFile("timg.png"), new Rectangle(0, 195, 115, 75));
        }

        public Size GetStringL(string str, Font font)
        {
            Graphics g = this.CreateGraphics();
            //单位为mm
            g.PageUnit = GraphicsUnit.Millimeter;
            SizeF sim = g.MeasureString(str, font);
            Size sz = new Size((int)sim.Width * str.Length, (int)sim.Height);
            //MessageBox.Show(sz.Width.ToString());
            return sz;
        }
    }
}
