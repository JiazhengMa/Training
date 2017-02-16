namespace ClassSystem
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new WindowsFormsAero.Button();
            this.textBox1 = new WindowsFormsAero.TextBox();
            this.comboBox1 = new WindowsFormsAero.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new WindowsFormsAero.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.verticalPanel1 = new WindowsFormsAero.VerticalPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.NavTool = new ClassSystem.List_Ex(this.components);
            this.panel1.SuspendLayout();
            this.verticalPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(185, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 504);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(556, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.CueBannerText = "Please enter the contents of the query";
            this.textBox1.Location = new System.Drawing.Point(186, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 23);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Course",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(58, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "lookup：";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(17, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(687, 431);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Course name";
            this.columnHeader8.Width = 303;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Student name";
            this.columnHeader9.Width = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to use";
            // 
            // verticalPanel1
            // 
            this.verticalPanel1.BackColor = System.Drawing.Color.Transparent;
            this.verticalPanel1.Controls.Add(this.label3);
            this.verticalPanel1.Controls.Add(this.NavTool);
            this.verticalPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalPanel1.Location = new System.Drawing.Point(0, 0);
            this.verticalPanel1.Name = "verticalPanel1";
            this.verticalPanel1.Size = new System.Drawing.Size(179, 612);
            this.verticalPanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Administrators";
            // 
            // NavTool
            // 
            this.NavTool.BackColor = System.Drawing.Color.Transparent;
            this.NavTool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavTool.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NavTool.FormattingEnabled = true;
            this.NavTool.ItemHeight = 35;
            this.NavTool.Items.AddRange(new object[] {
            "Course Information",
            "About us"});
            this.NavTool.Location = new System.Drawing.Point(1, 96);
            this.NavTool.Name = "NavTool";
            this.NavTool.Size = new System.Drawing.Size(178, 490);
            this.NavTool.TabIndex = 4;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.verticalPanel1.ResumeLayout(false);
            this.verticalPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsAero.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private List_Ex NavTool;
        private WindowsFormsAero.VerticalPanel verticalPanel1;
        private System.Windows.Forms.Label label3;
        private WindowsFormsAero.Button button1;
        private WindowsFormsAero.TextBox textBox1;
        private WindowsFormsAero.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}