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
    public partial class UC_Profile : UserControl
    {
        Repository _repository = new Repository();
        String query;
        
        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { userNameLabel.Text = value; }
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            query = "select * from users where username='" + userNameLabel.Text + "'";
            DataSet ds = _repository.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0]["userRole"].ToString();
            txtName.Text = ds.Tables[0].Rows[0]["name"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0]["pass"].ToString();
            txtDob.Text = ds.Tables[0].Rows[0]["dob"].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0]["mobile"].ToString();

        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.ToString();
            String userRole = txtUserRole.Text.ToString();
            String email = txtEmail.Text.ToString();
            String pass = txtPassword.Text.ToString();
            String dob = txtDob.Text.ToString();
            String mobile = txtMobile.Text.ToString();
            String username = userNameLabel.Text.ToString();

            query = "update users set userRole='" + userRole + "',name='" + name + "',email='" + email + "',pass='" + pass + "'," +
                "dob='" + dob + "',mobile='" + mobile + "' where username = '" + username + "'";
            _repository.setData(query, "Profile Update Successfully");
        }
    }
}
