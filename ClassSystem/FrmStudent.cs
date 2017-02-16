using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassSystem.db;

namespace ClassSystem
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        public string id;

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            Staff.FillList(ref listView1);
            Staff.FillList2(ref listView2,id);
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Staff.addClass(listView1.SelectedItems[0].Text,id);
                FrmStudent_Load(null, null);
            }
        }

        private void 移除课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Staff.delClass(listView2.SelectedItems[0].Text);
                FrmStudent_Load(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff.FillList(ref listView1,"",textBox1.Text);
        }

        private void FrmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
