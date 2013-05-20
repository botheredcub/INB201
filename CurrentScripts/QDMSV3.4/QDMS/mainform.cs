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
    public partial class mainform : Form
    {
        // Form Index
        public readonly int INDEX = 0;
        public readonly int REGION = 1;
        public readonly int INCIDENT_MANAGEMENT = 2;
        public readonly int PERSONNEL_MANAGEMENT = 3;


        // List the forms into a list
        List<Form> Forms;

        //Initialilise the parent MDI and setup the forms with their properties
        //Add the forms into a list.
        public mainform() {
            InitializeComponent();

            Forms = new List<Form>();

            index indexForm = new index(this);
            indexForm.MdiParent = this;
            indexForm.Dock = DockStyle.Fill;

            region regionForm = new region(this);
            regionForm.MdiParent = this;
            regionForm.Dock = DockStyle.Fill;

            Incident_management IMForm = new Incident_management(this);
            IMForm.MdiParent = this;
            IMForm.Dock = DockStyle.Fill;

            Personnel_Management PMForm = new Personnel_Management(this);
            PMForm.MdiParent = this;
            PMForm.Dock = DockStyle.Fill;



            Forms.Add(indexForm);
            Forms.Add(regionForm);
            Forms.Add(IMForm);
            Forms.Add(PMForm);
            Forms[REGION].Show();
        }

        //Create a general navigation class using the form list index.
        public void OpenForms(int i)
        {
            Forms[i].Show();
            Forms[i].Activate();
        }

        private void loginMenuItem_Click(object sender, EventArgs e) {
            OpenForms(INDEX);
        }

        private void exit_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms(INCIDENT_MANAGEMENT);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForms(REGION);
        }

        private void personnelManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForms(PERSONNEL_MANAGEMENT);
        }

    }
}
