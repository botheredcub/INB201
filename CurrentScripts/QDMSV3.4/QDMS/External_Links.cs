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
    public partial class External_Links : Form
    {
        public External_Links()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
        try
        {
        QLD_GOV_VisitLink();
        }
        catch (Exception)
        {
        MessageBox.Show("Unable to open link that was clicked.");
        }
        }

        private void QLD_GOV_VisitLink()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("http://www.qld.gov.au");
        }
        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                QLD_DIS_VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void QLD_DIS_VisitLink()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("http://www.disaster.qld.gov.au/");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
              {
            try
            {
                AUS_DIS_VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void AUS_DIS_VisitLink()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("http://www.em.gov.au/Pages/default.aspx");
        }


        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ABC_VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void ABC_VisitLink()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("http://www.abc.net.au");
        }

    }
}
