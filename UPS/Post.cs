using System;
using System.Windows.Forms;
using UPS.Models;
using UPS.RestLayer;

namespace UPS.Desktop
{
    public partial class Post : Form
    {
        bool update = false;
        public Post()
        {
            InitializeComponent();
        }

        public Post(long id, string name, string gender, string email, string status)
        {
            update = true;
            InitializeComponent();
            lblId.Text = id.ToString();
            txtName.Text = name;
            txtEmail.Text = email;
            cmbGender.Text = gender;
            cmbStatus.Text = status;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            cmbGender.Text= "";
            cmbStatus.Text= "";  
            this.Hide();
        }

        private void lblSave_Click(object sender, EventArgs e)
        { 
            if (update)
            {
                Employee employee = new Employee()
                {
                    Id = long.Parse(lblId.Text),
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Gender = cmbGender.Text,
                    Status = cmbStatus.Text
                };

                var result = EmployeeService.UpdateEmployee(employee);
                MessageBox.Show(result);
            }
            else
            {
                Employee employee = new Employee()
                { 
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Gender = cmbGender.Text,
                    Status = cmbStatus.Text
                };
                
                var result = EmployeeService.CreateEmployee(employee);  
                MessageBox.Show(result); 
            }
            
        }
    }
}
