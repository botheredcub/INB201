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
    public partial class index : Form
    {
        mainform parent;

        public index(mainform parent)
        {
            InitializeComponent();

            this.parent = parent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Skip_Click(object sender, EventArgs e) {

            parent.OpenForms(parent.REGION);
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void usertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtextbox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
