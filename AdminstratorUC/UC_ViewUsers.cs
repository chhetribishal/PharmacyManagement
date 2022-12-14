using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.AdminstratorUC
{
    public partial class UC_ViewUsers : UserControl
    {
        Repository _repository = new Repository();
        String query;
        String currentUser = "";
        public UC_ViewUsers()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void UC_ViewUsers_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds =_repository.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where userName like '" + txtUserName.Text + "%'"; //a%
            DataSet ds = _repository.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch(Exception)
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "delete from users where username='" + userName + "'";
                    _repository.setData(query, "User Record Deleted Successfully");
                    UC_ViewUsers_Load(this, null);

                }
                else
                {
                    MessageBox.Show("You are trying to delete\n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUsers_Load(this, null);
        }
    }
}
