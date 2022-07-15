using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmMain : Form
    {
        public Member Member { get; set; }
        public bool IsAdmin { get; set; }
        public FStoreContext StoreContext { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Member = null;
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            FrmMember frmMember = new FrmMember
            {
                Member = Member,
                IsAdmin = IsAdmin,
                StoreContext = StoreContext
            };
            frmMember.MdiParent = this;
            frmMember.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (IsAdmin != true)
            {
                //btnMemberManagement.Enabled = false;
            }
            else
            {
                //btnMemberManagement.Enabled = true;
            }
        }
    }
}
