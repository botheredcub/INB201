using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Incident_management : Form
    {
        mainform parent;

        public Incident_management(mainform parent)
        {
            InitializeComponent();

            this.parent = parent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }



        private void button1_Click(object sender, EventArgs e)
        
            {
                DBConnect DB = new DBConnect();
                DB.Select_City_list(); 

            }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Incident_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IncidentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Incident_address_TextChanged(object sender, EventArgs e)
        {
           var incident = Incident_address.Text; 

        }

        private void Submit1_Click(object sender, EventArgs e)
        {
 
        }

        private void Incident_type_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
