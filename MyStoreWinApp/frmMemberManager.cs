using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1.BusinessObject;
using DataAccess.Repository;
namespace MyStoreWinApp
{
    public partial class frmMemberManager : Form
    {

        IMemberRepository memRepository = new MemberRepository();
        public frmMemberManager()
        {
            InitializeComponent();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            tbId.Text = dgvList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            tbName.Text = dgvList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            tbMail.Text = dgvList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            tbPass.Text = dgvList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbCity.SelectedItem = dgvList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            cbCountry.SelectedItem = dgvList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberID = int.Parse(tbId.Text);
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem.ToString();
                mem.Country = cbCountry.SelectedItem.ToString();
                mem.Password = tbPass.Text;

                memRepository.DeleteMember(mem);
                MessageBox.Show("Delete succed!");
                List<MemberObject>obj = memRepository.GetAllMembers().ToList();
                dgvList.DataSource = obj;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberID = int.Parse(tbId.Text);
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem.ToString();
                mem.Country = cbCountry.SelectedItem.ToString();
                mem.Password = tbPass.Text;

                memRepository.UpdateMember(mem);
                MessageBox.Show("Update succed!");
                List<MemberObject>obj = memRepository.GetAllMembers().ToList();
                dgvList.DataSource =obj;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem.ToString();
                mem.Country = cbCountry.SelectedItem.ToString();
                mem.Password = tbPass.Text;

                memRepository.AddMember(mem);
                MessageBox.Show("Insert succed!");
                List<MemberObject>obj = memRepository.GetAllMembers().ToList();
                dgvList.DataSource =obj;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbId.Text = string.Empty;
            tbName.Text = string.Empty;
            tbMail.Text = string.Empty;
            tbPass.Text = string.Empty;
            cbCity.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            tbSearch.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MemberObject> obj = null;
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                obj = memRepository.GetAllMembers().ToList();
            }
            else
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    obj = memRepository.GetMembersByCountry(cbFilterTitle.SelectedItem.ToString(), tbSearch.Text).ToList();
                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    obj = memRepository.GetMembersByCity(cbFilterTitle.SelectedItem.ToString(), tbSearch.Text).ToList();
                }
            }
            if (cbNameAndId.SelectedIndex == 0)
            {
                if (cbAscAndDesc.SelectedIndex == 0)
                {

                    obj = obj.OrderBy(mem => mem.MemberID).ToList();
                }
                else
                {
                    obj = obj.OrderByDescending(mem => mem.MemberID).ToList();
                }
            }
            else if (cbNameAndId.SelectedIndex == 1)
            {
                if (cbAscAndDesc.SelectedIndex == 0)
                {
                    obj = obj.OrderBy(mem => mem.MemberName).ToList();
                }
                else
                {
                    obj = obj.OrderByDescending(mem => mem.MemberName).ToList();
                }
            }
            dgvList.DataSource = obj;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                cbFilterTitle.DataSource = memRepository.GetCountry();
                cbFilterTitle.DisplayMember = "Country";
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                cbFilterTitle.DataSource = memRepository.GetCities();
                cbFilterTitle.DisplayMember = "City";
            }
        }

        private void frmMemberManager_Load(object sender, EventArgs e)
        {
            List<MemberObject> obj = memRepository.GetAllMembers().ToList();
            dgvList.DataSource = obj;
            cbFilter.SelectedIndex = 0;
            cbAscAndDesc.SelectedIndex = 0;
            cbNameAndId.SelectedIndex = 0;
            cbCountry.DataSource = memRepository.GetCountry();
            cbCountry.SelectedIndex = 0;

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.DataSource = memRepository.GetCities(cbCountry.SelectedItem.ToString());
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }

        
    }
}
