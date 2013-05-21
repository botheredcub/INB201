using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Personnel_Management : Form
    {
         mainform parent;
         DBConnect DB;

        public Personnel_Management(mainform parent)
        {
            InitializeComponent();
            DB = new DBConnect();

            this.parent = parent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void People_Management_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            DB.Insert_personnel();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string>[] list = DB.Select_Personnel_Information_about();

            MessageBox.Show(list[0][1]);
            MessageBox.Show(list[1][1]);
            MessageBox.Show(list[2][1]);
            MessageBox.Show(list[3][1]);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
