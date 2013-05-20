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

            Incident_type_box.Items.Add("Fire");
            Incident_type_box.Items.Add("Cyclone");
            Incident_type_box.Items.Add("Eathquake");
            Incident_type_box.Items.Add("Flood");
            Incident_type_box.Items.Add("Firestorm");
            Incident_type_box.Items.Add("Monsoon");
            Incident_type_box.Items.Add("other");
            Incident_type_box.Items.Add("Tsunami");

            Current_status_list.Items.Add("Normal");
            Current_status_list.Items.Add("Safe");
            Current_status_list.Items.Add("on-alert");
            Current_status_list.Items.Add("Evacuate");
            Current_status_list.Items.Add("Emergency");

            Warning_list.Items.Add("Definate");
            Warning_list.Items.Add("high");
            Warning_list.Items.Add("Moderate");
            Warning_list.Items.Add("Low");
            Warning_list.Items.Add("Definate");

            Incident_id_update.Items.Add("Normal");
            Incident_id_update.Items.Add("safe");
            Incident_id_update.Items.Add("on-alert");
            Incident_id_update.Items.Add("Evacuate");
            Incident_id_update.Items.Add("Emergency");
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
