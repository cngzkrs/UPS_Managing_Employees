using System;
using System.Windows.Forms;
using UPS.Desktop;
using UPS.RestLayer;

namespace UPS
{
    public partial class Form1 : Form
    {
        long pageNum;
        public Form1()
        {
            InitializeComponent();
            dgvEmployees.AutoGenerateColumns = true;
            lblpgnum.Text = "";
        }

        private void btnGetAllEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                pageNum = 1;
                lblpgnum.Text = pageNum.ToString();
                var result = EmployeeService.GetAllEmployees(pageNum);
                dgvEmployees.DataSource = result.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                var result = EmployeeService.GetAllEmployees(--pageNum);
                lblpgnum.Text = result.Meta.Pagination.Page.ToString();
                dgvEmployees.DataSource = result.Data;

                if (pageNum == 1)
                {
                    btnLeft.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                lblPageNum.Enabled = true;
                var result = EmployeeService.GetAllEmployees(++pageNum);
                lblpgnum.Text = result.Meta.Pagination.Page.ToString();
                dgvEmployees.DataSource = result.Data;

                if (!btnLeft.Enabled) btnLeft.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetEmpsByName_Click(object sender, EventArgs e)
        {
            try
            {
                var result = EmployeeService.GetEmployeeByName(txtEmpName.Text);
                lblpgnum.Text = result.Meta.Pagination.Page.ToString();
                dgvEmployees.DataSource = result.Data;
                ClearTexts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var postForm = new Post();
            postForm.Show();
        }

        private void btnGetEmployeeById_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtUserId.Text, out int id))
                {
                    var result = EmployeeService.GetEmployeeById(id);
                    lblpgnum.Text = result.Meta.Pagination.Page.ToString();
                    dgvEmployees.DataSource = result.Data;
                    ClearTexts();
                }
                else
                {
                    MessageBox.Show("Id cannot be null!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPutById_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtPut.Text, out int id))
                {
                    var result = EmployeeService.GetEmployeeById(id);
                    var postForm = new Post(result.Data[0].Id, result.Data[0].Name, result.Data[0].Gender, result.Data[0].Email, result.Data[0].Status);
                    postForm.Show();
                    ClearTexts();
                }
                else
                {
                    MessageBox.Show("Id cannot be null!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtDeleteById.Text, out int id))
                {
                    var result = EmployeeService.DeleteEmployee(id); 
                    ClearTexts();
                    MessageBox.Show(result);

                    var resultAll = EmployeeService.GetAllEmployees(pageNum);
                    dgvEmployees.DataSource = resultAll.Data;
                }
                else
                {
                    MessageBox.Show("Id cannot be null!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearTexts()
        {
            txtDeleteById.Text = "";
            txtEmpName.Text = "";
            txtPut.Text = "";
            txtUserId.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
