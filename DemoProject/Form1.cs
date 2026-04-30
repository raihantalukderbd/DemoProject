using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@username", txtUsername.Text),
                new SqlParameter("@password", txtPassword.Text)
            };

            DataTable dt = da.ExecuteQuery(query, param);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
