using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {

        Repository _repository = new Repository();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMedicineId.Text!="" && txtMedicineName.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="" && txtMedicineNumber.Text != "")
            {
                String mid = txtMedicineId.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpireDate.Text;
                Int64 quantity = Convert.ToInt64(txtQuantity.Text);
                Int64 perunit = Convert.ToInt64(txtPricePerUnit.Text);

                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('"+mid+"', '"+mname+"','"+mnumber+"', '"+mdate+"', '"+edate+"',"+quantity+", "+perunit+")";
                _repository.setData(query, "Medicine is added Successfully");
                clearAll();
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtQuantity.Clear();
            txtMedicineNumber.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
        }
    }
}
