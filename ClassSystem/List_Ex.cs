using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace ClassSystem
{
    public partial class List_Ex : ListBox
    {
        public List_Ex()
        {
            InitializeComponent();
            base.DrawMode = DrawMode.OwnerDrawFixed;
            base.ItemHeight = 35;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲   
            this.SetStyle(ControlStyles.ResizeRedraw, true); // 调整大小时重绘
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景. 
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // 开启控件透明
        }

        public List_Ex(IContainer container)
        {

            InitializeComponent();
            base.DrawMode = DrawMode.OwnerDrawFixed;
            base.ItemHeight = 35;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲   
            this.SetStyle(ControlStyles.ResizeRedraw, true); // 调整大小时重绘
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景. 
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // 开启控件透明
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            if (this.Focused && this.SelectedItem != null)
            {
                Rectangle itemRect = this.GetItemRectangle(this.SelectedIndex);
                itemRect.Height = itemRect.Height - 1;
                Color drawColor = Color.FromArgb(100, Color.Black);
                //// 定义画笔
                Pen labelBorderPen = new Pen(drawColor, 0);
                SolidBrush labelBackColorBrush = new SolidBrush(drawColor);

                e.Graphics.FillRectangle(labelBackColorBrush, itemRect);
            }

            for (int i = 0; i < Items.Count; i++)
            {
                SolidBrush lb = new SolidBrush(Color.FromArgb(50, Color.Black));
                Rectangle rc = this.GetItemRectangle(i);
                rc.Height = rc.Height - 1;
                e.Graphics.FillRectangle(lb, rc);

                StringFormat strFmt = new System.Drawing.StringFormat();
                strFmt.Alignment = StringAlignment.Center;
                strFmt.LineAlignment = StringAlignment.Center; //文本水平居中  
                e.Graphics.DrawString(this.GetItemText(this.Items[i]), this.Font, new SolidBrush(this.ForeColor), this.GetItemRectangle(i), strFmt);
                strFmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString("〉", this.Font, new SolidBrush(this.ForeColor), this.GetItemRectangle(i), strFmt);
            }
            base.OnPaint(e);
        }


    }
}
