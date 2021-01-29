using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystem
{
    public partial class FormAddEditAdmin : Form
    {
        bool isNew;
        public FormAddEditAdmin(Admin ad)
        {
            InitializeComponent();
            if (ad == null)
            {
                adminBindingSource.DataSource = new Admin();
                isNew = true;

            }
            else
            {
                adminBindingSource.DataSource = ad;
                isNew = false;
            }
           
        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void FormAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtNom.Text))
                {
                    MessageBox.Show("Insérez votre nom s'il vous palit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNom.Focus();
                    e.Cancel = true;
                    return;
                }
                if (isNew)
                {
                    AdminService.InsertAdmin(adminBindingSource.Current as Admin);
                }
                else
                {
                    AdminService.UpdateAdmin(adminBindingSource.Current as Admin);
                }


            }
        }
    }
}
