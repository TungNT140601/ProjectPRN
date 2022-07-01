using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void closeCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. create and intital Object Form Add
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            //2.
            f1.Show();
        }
    }
}
