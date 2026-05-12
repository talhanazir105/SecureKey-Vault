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
            // Aapki copy ki hui connection string
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

            // Check karte hain ke textbox khali to nahi
            if (string.IsNullOrEmpty(txtMasterKey.Text))
            {
                MessageBox.Show("Please enter your Master Key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database se connection banana
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Database me check karna ke ye master key App_User table me hai ya nahi
                    string query = "SELECT COUNT(*) FROM App_User WHERE Master_Key = @key";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@key", txtMasterKey.Text);
                        int count = (int)cmd.ExecuteScalar(); // Ye count karega ke kitne match hue

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Naya naam frmDashboard use karein
                            frmDashboard dashboard = new frmDashboard();
                            dashboard.Show();

                            // Login form ko hide kar dein
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
                    // Agar database connect hone me koi masla aaye to error dikhaye
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
