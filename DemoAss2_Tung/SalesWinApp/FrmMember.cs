using BussinessObject.Models;
using DataAccess.Repositories;
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
    public partial class FrmMember : Form
    {
        public Member Member { get; set; }
        public bool IsAdmin { get; set; }
        public FStoreContext StoreContext { get; set; }
        private IMemberRepository memberRepository;
        //BindingSource source;
        public FrmMember()
        {
            InitializeComponent();
        }
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Companyname = txtCompanyname.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member Object");
            }
            return member;
        }
        private void LoadMemberList()
        {
            if (dgvMemberList.RowCount != 0)
            {
                dgvMemberList.DataMember = null;
            }
            memberRepository = new MemberRepository
            {
                fStoreContext = StoreContext
            };
            dgvMemberList.ColumnCount = 6;
            dgvMemberList.Columns[0].Name = "MemberId";
            dgvMemberList.Columns[1].Name = "Email";
            dgvMemberList.Columns[2].Name = "City";
            dgvMemberList.Columns[3].Name = "Companyname";
            dgvMemberList.Columns[4].Name = "Country";
            dgvMemberList.Columns[5].Name = "Password";
            if (IsAdmin == true)
            {
                var members = memberRepository.GetMemberList();
                try
                {
                    if (members.Count() == 0)
                    {
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        if (dgvMemberList.RowCount != memberRepository.GetMemberList().Count())
                        {
                            string[] row = null;
                            foreach (var member in members)
                            {
                                row = new string[]
                                {
                                member.MemberId.ToString(),
                                member.Email,
                                member.City,
                                member.Companyname,
                                member.Country,
                                member.Password
                                };
                                dgvMemberList.Rows.Add(row);
                            }
                        }
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Load Admin Member List");
                }
            }
            else
            {
                try
                {
                    if (dgvMemberList.RowCount == 1)
                    {
                        string[] row = null;
                        row = new string[]
                                {
                                Member.MemberId.ToString(),
                                Member.Email,
                                Member.City,
                                Member.Companyname,
                                Member.Country,
                                Member.Password
                                };
                        dgvMemberList.Rows.Add(row);
                    }
                    btnLoad.Enabled = false;
                    btnUpdate.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Load Admin Member List");
                }
            }
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmMemberDetail frmMemberDetail = new FrmMemberDetail
            {
                InsertOrUpdate = true,
                FStoreContext = StoreContext
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmMemberDetail frmMemberDetail = new FrmMemberDetail
            {
                Member = GetMemberObject(),
                InsertOrUpdate = false,
                FStoreContext = StoreContext
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                memberRepository = new MemberRepository
                {
                    fStoreContext = StoreContext
                };
                memberRepository.DeleteMember(GetMemberObject());
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Error");
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmMemberDetail frmMemberDetail = new FrmMemberDetail
            {
                Member = GetMemberObject(),
                InsertOrUpdate = false,
                FStoreContext = StoreContext
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCompanyname.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void dgvMemberList_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMemberList.SelectedRows)
            {
                ClearText();

                if (row.Cells[0].Value != null)
                {
                    txtMemberID.Text = row.Cells[0].Value.ToString();
                    txtEmail.Text = row.Cells[1].Value.ToString();
                    txtCity.Text = row.Cells[2].Value.ToString();
                    txtCompanyname.Text = row.Cells[3].Value.ToString();
                    txtCountry.Text = row.Cells[4].Value.ToString();
                    txtPassword.Text = row.Cells[5].Value.ToString();
                }
            }
        }
    }
}
