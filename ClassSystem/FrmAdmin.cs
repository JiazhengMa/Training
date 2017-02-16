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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            StaffInfo.BanList(ref listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffInfo.BanList(ref listView1,comboBox1.SelectedIndex.ToString(),textBox1.Text);
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
