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
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Teacher.FillList(ref listView1);
        }
        private bool isUpdate;
        private string id;
        private void NavTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (NavTool.SelectedIndex)
            {
                case 0:
                    label1.Text = "Add or modify course information";
                    panel1.Visible = true;
                    //panel2.Visible = true;
                    break;
                case 1:
                    panel1.Visible = false;
                    label1.Text = "About us";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher.FillList(ref listView1,comboBox1.SelectedIndex.ToString(),textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                Teacher.updataClass(id, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox4.Text, textBox5.Text);
            }
            else
            {
                Teacher.addClass(textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox4.Text, textBox5.Text);
            }
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Add course";
            isUpdate = false;
        }

        private void 修改课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                id = listView1.SelectedItems[0].Text;
                groupBox1.Text = "Update course  ID is " + id;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
                isUpdate = true;
            }  
        }

        private void FrmTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
