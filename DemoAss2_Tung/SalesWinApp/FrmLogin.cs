using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using BussinessObject.Models;
using DataAccess.Repositories;

namespace SalesWinApp
{
    public partial class FrmLogin : Form
    {
        IMemberRepository MemberRepository = new MemberRepository();
        private FStoreContext FStoreContext = new FStoreContext(GetConnectionString());
        private static string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();
            connectionString = config["ConnectionString:FStoreDB"];
            return connectionString;
        }
        public Member GetAdmin()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();
            return new Member
            {
                MemberId = int.Parse(config["Admin:MemberId"]),
                Email = config["Admin:Email"],
                City = config["Admin:City"],
                Companyname = config["Admin:Companyname"],
                Country = config["Admin:Country"],
                Password = config["Admin:Password"]
            };
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FStoreContext fStoreContext = new FStoreContext();
                Member member = new Member();
                Member admin = GetAdmin();
                if (admin.Email.Equals(txtEmail.Text) && admin.Password.Equals(txtPassword.Text))
                {
                    FrmMain frmMain = new FrmMain
                    {
                        IsAdmin = true,
                        Member = admin,
                        StoreContext = FStoreContext
                    };
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    member = MemberRepository.CheckLogin(txtEmail.Text.ToString(), txtPassword.Text.ToString());
                    if (member != null)
                    {
                        FrmMain frmMain = new FrmMain
                        {
                            IsAdmin = false,
                            Member = member,
                            StoreContext = FStoreContext
                        };
                        frmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception("Login fail!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnShow.Checked = false;
            btnShow.Text = "Show Password";
            txtPassword.UseSystemPasswordChar = true;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnShow.Text = "Show Password";
            }
            else
            {
                btnShow.Text = "Hide Password";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnShow.Text = "Show Password";
            }
            else
            {
                btnShow.Text = "Hide Password";
            }
        }
    }
}
