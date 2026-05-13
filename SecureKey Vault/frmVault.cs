using SecureKeyVault;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureKey_Vault
{
    public partial class frmVault : Form
    {
        // Connection string (isay apne computer ke mutabiq check kar lein agar error aaye)
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

        public int RecordID = 0;

        public frmVault()
        {
            InitializeComponent();
        }

        // Function: Database se data la kar table me masked password ke sath dikhana
        private void LoadAllData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Hum query mein hi '********' mangwa rahe hain security ke liye
                    string query = "SELECT ID, PlatformName, Username, '********' AS Password FROM Vault_Data";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Grid me data show karna
                    dgvVault.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmVault_Load(object sender, EventArgs e)
        {
            LoadAllData(); // Form open hoty hi table bhar jaye ga
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVault_SelectionChanged(object sender, EventArgs e)
        {
            // Jab bhi table me selection change ho
            if (dgvVault.SelectedRows.Count > 0)
            {
                // Selected row se ID aur details nikalna
                int selectedId = Convert.ToInt32(dgvVault.SelectedRows[0].Cells["ID"].Value);
                txtEditPlatform.Text = dgvVault.SelectedRows[0].Cells["PlatformName"].Value.ToString();
                txtEditUsername.Text = dgvVault.SelectedRows[0].Cells["Username"].Value.ToString();

                // Ab asal password database se decrypt karke layein gy
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT SavedPassword FROM Vault_Data WHERE ID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // SecurityHelper use karke decrypt karna
                            string encryptedPwd = result.ToString();
                            txtEditPassword.Text = SecurityHelper.DecryptBase64(encryptedPwd);
                        }
                    }
                }

                // Default password chupa hua aye (*) niche walay daby me
                txtEditPassword.PasswordChar = '*';
            }
        }

        private void btnShowEditPwd_Click(object sender, EventArgs e)
        {
            // Password show ya hide karne ki logic
            if (txtEditPassword.PasswordChar == '*')
            {
                txtEditPassword.PasswordChar = '\0'; // Show password
                btnShowEditPwd.Text = "🙈"; // Icon change (khali eye se band ankhen emoji)
            }
            else
            {
                txtEditPassword.PasswordChar = '*'; // Hide password
                btnShowEditPwd.Text = "👁️"; // Icon back to normal eye
            }
        }

        private void btnVaultUpdate_Click(object sender, EventArgs e)
        {
            if (dgvVault.SelectedRows.Count > 0)
            {
                // Check ke koi dabba khali na ho
                if (string.IsNullOrEmpty(txtEditPlatform.Text) || string.IsNullOrEmpty(txtEditPassword.Text))
                {
                    MessageBox.Show("Platform and Password are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedId = Convert.ToInt32(dgvVault.SelectedRows[0].Cells["ID"].Value);

                // Naya password wapas encrypt karna
                string newEncryptedPwd = SecurityHelper.EncryptBase64(txtEditPassword.Text);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string updateQuery = "UPDATE Vault_Data SET PlatformName = @plat, Username = @user, SavedPassword = @pwd WHERE ID = @id";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@plat", txtEditPlatform.Text);
                            cmd.Parameters.AddWithValue("@user", txtEditUsername.Text);
                            cmd.Parameters.AddWithValue("@pwd", newEncryptedPwd);
                            cmd.Parameters.AddWithValue("@id", selectedId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Securely!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadAllData(); // Table refresh karna
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVaultDelete_Click(object sender, EventArgs e)
        {
            if (dgvVault.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvVault.SelectedRows[0].Cells["ID"].Value);
                string platformName = dgvVault.SelectedRows[0].Cells["PlatformName"].Value.ToString();

                // Confirm karna
                DialogResult dialog = MessageBox.Show($"Are you sure you want to permanently delete {platformName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM Vault_Data WHERE ID = @id";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record Deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Dabbe khali karna
                            txtEditPlatform.Clear();
                            txtEditUsername.Clear();
                            txtEditPassword.Clear();

                            LoadAllData(); // Table refresh karna
                        }
                    }
                }
            }
        }
    }
}