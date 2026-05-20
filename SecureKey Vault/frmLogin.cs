using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecureKey_Vault
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

            
            if (string.IsNullOrEmpty(txtMasterKey.Text))
            {
                MessageBox.Show("Please enter your Master Key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    
                    string query = "SELECT COUNT(*) FROM App_User WHERE Master_Key = @key";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@key", txtMasterKey.Text);
                        int count = (int)cmd.ExecuteScalar(); 

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmDashboard dashboard = new frmDashboard();
                            dashboard.Show();

                            
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Master Key! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
    }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
