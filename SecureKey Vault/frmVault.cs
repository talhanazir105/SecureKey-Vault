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
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

        public int RecordID = 0;

        public frmVault()
        {
            InitializeComponent();
        }

        
        private void LoadAllData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT ROW_NUMBER() OVER (ORDER BY ID) AS [Sr. No], ID, PlatformName, Username, '********' AS Password FROM Vault_Data";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgvVault.DataSource = dt;

                    dgvVault.Columns["ID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmVault_Load(object sender, EventArgs e)
        {
            LoadAllData(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVault_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVault.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvVault.SelectedRows[0].Cells["ID"].Value);
                txtEditPlatform.Text = dgvVault.SelectedRows[0].Cells["PlatformName"].Value.ToString();
                txtEditUsername.Text = dgvVault.SelectedRows[0].Cells["Username"].Value.ToString();

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
                            string encryptedPwd = result.ToString();
                            txtEditPassword.Text = SecurityHelper.DecryptBase64(encryptedPwd);
                        }
                    }
                }

                txtEditPassword.PasswordChar = '*';
            }
        }

        private void btnShowEditPwd_Click(object sender, EventArgs e)
        {
            if (txtEditPassword.PasswordChar == '*')
            {
                txtEditPassword.PasswordChar = '\0'; 
                btnShowEditPwd.Text = "🙈";
            }
            else
            {
                txtEditPassword.PasswordChar = '*'; 
                btnShowEditPwd.Text = "👁️"; 
            }
        }

        private void btnVaultUpdate_Click(object sender, EventArgs e)
        {
            if (dgvVault.SelectedRows.Count > 0)
            {
               
                if (string.IsNullOrEmpty(txtEditPlatform.Text) || string.IsNullOrEmpty(txtEditPassword.Text))
                {
                    MessageBox.Show("Platform and Password are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedId = Convert.ToInt32(dgvVault.SelectedRows[0].Cells["ID"].Value);

                
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

                            LoadAllData(); 
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

                            
                            txtEditPlatform.Clear();
                            txtEditUsername.Clear();
                            txtEditPassword.Clear();

                            LoadAllData(); 
                        }
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}