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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeMasterKey_Click(object sender, EventArgs e)
        {
            // Aapki database ki connection string
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

            // Pehle check karte hain ke koi dabba khali to nahi chhora
            if (string.IsNullOrEmpty(txtCurrentKey.Text) || string.IsNullOrEmpty(txtNewKey.Text))
            {
                MessageBox.Show("Please fill both fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Step A: Database se puchte hain ke kiya purana password theek hai?
                    string checkQuery = "SELECT COUNT(*) FROM App_User WHERE Master_Key = @currentKey";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@currentKey", txtCurrentKey.Text);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Step B: Agar purana password theek hai, to naya password update kar do
                            string updateQuery = "UPDATE App_User SET Master_Key = @newKey";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@newKey", txtNewKey.Text);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Master Key updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Update hone ke baad dabbe khud khali ho jayein
                                txtCurrentKey.Clear();
                                txtNewKey.Clear();
                            }
                        }
                        else
                        {
                            // Agar purana password galat dala
                            MessageBox.Show("Current Master Key is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
