using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartment.Items.Add("HR");
            cmbDepartment.Items.Add("Finance");
            cmbDepartment.Items.Add("IT");
            cmbDepartment.Items.Add("Marketing");
            cmbDepartment.Items.Add("Admin");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Employee Name.");
                return;
            }

            if (numAge.Value < 18 || numAge.Value > 65)
            {
                MessageBox.Show("Employee Age must be between 18 and 65.");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbAddress.Text))
            {
                MessageBox.Show("Please enter Address.");
                return;
            }

            if (!Regex.IsMatch(txtMobile.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Enter a valid 10-digit mobile number.");
                return;
            }

            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Department.");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid Email ID.");
                return;
            }

            MessageBox.Show("Employee Registered Successfully!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
