//Joshua Pickenpaugh
//October 17th, 2016
//Just brushing up on C# syntax. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_01
{
    public partial class frmMain : Form
    {
        DisplayObject dispOb = new DisplayObject();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            dispOb.Name = txtName.Text;
            lblDisplay.Text = dispOb.Name;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Nothing.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Nothing.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dispOb.Clear();
        }
    }
}
