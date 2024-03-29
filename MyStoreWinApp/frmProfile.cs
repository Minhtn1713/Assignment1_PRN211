﻿using Assignment1.BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmProfile : Form
    {
        IMemberRepository memRepository = new MemberRepository();

        public frmProfile()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        public frmProfile(MemberObject mem) : this()
        {
            if (mem != null)
            {
                MemberObject tmp = memRepository.GetMemberById(mem.MemberID);
                DisplayMember(tmp);
            }
        }

        private void InitializeComboBoxes()
        {
            cbCountry.DataSource = memRepository.GetCountry();
        }

        private void DisplayMember(MemberObject mem)
        {
            if (mem != null)
            {
                tbName.Text = mem.MemberName;
                tbPass.Text = mem.Password;
                tbMail.Text = mem.Email;
                tbId.Text = mem.MemberID.ToString();
                cbCountry.SelectedItem = mem.Country;

                if (cbCountry.SelectedItem != null)
                {
                    cbCity.DataSource = memRepository.GetCities(cbCountry.SelectedItem.ToString());
                    cbCity.SelectedItem = mem.City;
                }
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedItem != null)
            {
                cbCity.DataSource = memRepository.GetCities(cbCountry.SelectedItem.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject mem = new MemberObject();
                mem.MemberID = int.Parse(tbId.Text);
                mem.MemberName = tbName.Text;
                mem.Email = tbMail.Text;
                mem.City = cbCity.SelectedItem?.ToString();
                mem.Country = cbCountry.SelectedItem?.ToString();
                mem.Password = tbPass.Text;

                memRepository.UpdateMember(mem);
                MessageBox.Show("Update succeeded!");

                MemberObject updatedMember = memRepository.GetMemberById(mem.MemberID);
                DisplayMember(updatedMember);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e) => Close();
    }
}
