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
using DataAccess.Repositories;

namespace SalesWinApp
{
    public partial class FrmMemberDetail : Form
    {
        private IMemberRepository memberRepository;
        public Member Member { get; set; }
        public bool InsertOrUpdate { get; set; }
        public FStoreContext FStoreContext { get; set; }
        public FrmMemberDetail()
        {
            InitializeComponent();
        }

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == false)
            {
                txtMemberID.Text = Member.MemberId.ToString();
                txtMemberID.ReadOnly = true;
                txtCity.Text = Member.City;
                txtCompanyname.Text = Member.Companyname;
                txtCountry.Text = Member.Country;
                txtEmail.Text = Member.Email;
                txtPassword.Text = Member.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            memberRepository = new MemberRepository
            {
                fStoreContext = FStoreContext
            };
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Companyname = txtCompanyname.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                if (InsertOrUpdate == false)
                {
                    memberRepository.UpdateMember(member);
                }
                else
                {
                    memberRepository.AddMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add ERROR!!!!");
            }
        }
    }
}
