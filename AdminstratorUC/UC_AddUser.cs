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
    public partial class UC_AddUser : UserControl
    {
        Repository _repository = new Repository();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

       

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String username = txtUsername.Text;
            String email = txtEmail.Text;
            String pass = txtPassword.Text;
            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values('"+role+"','"+name+ "','" +dob+ "','" +mobile+ "','" +email+ "','" + username+ "','" +pass+ "')";
                _repository.setData(query, "User Added Successfully");
            }catch(Exception)
            {
                MessageBox.Show("User Added already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll(); 
        }

        public void clearAll()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
            txtUsername.Clear();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username ='" + txtUsername.Text + "'";
           DataSet ds = _repository.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                userNameCheckImg.ImageLocation = @"F:\.netProjects\PHarmacyProjectsImages\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                userNameCheckImg.ImageLocation = @"F:\.netProjects\PHarmacyProjectsImages\Pharmacy Management System in C#\no.png";

            }
        }
    }
}
