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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adminBindingSource.DataSource = AdminService.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddEditAdmin form=new FormAddEditAdmin(null)) {
                if (form.ShowDialog()==DialogResult.OK)
                {

                    adminBindingSource.DataSource = AdminService.GetAll();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (adminBindingSource.DataSource == null)
                return;
            using (FormAddEditAdmin form = new FormAddEditAdmin(adminBindingSource.Current as Admin))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    adminBindingSource.DataSource = AdminService.GetAll();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (adminBindingSource.Current == null)
                return;
            if (MessageBox.Show("Voulez vous eliminer cet administrateur", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                AdminService.DeleteAdmin(adminBindingSource.Current as Admin);
                adminBindingSource.RemoveCurrent();
            }
            
        }
    }
}
