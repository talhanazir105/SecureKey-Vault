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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmVault objVault = new frmVault();
            objVault.ShowDialog(); 
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnChangeMasterKey_Click(object sender, EventArgs e)
        {
            
            frmSecurityCheck pinForm = new frmSecurityCheck();
            pinForm.ShowDialog(); 

            
            if (pinForm.IsVerified == false)
            {
                return;
            }

            
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

            
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

                    
                    string checkQuery = "SELECT COUNT(*) FROM App_User WHERE Master_Key = @currentKey";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@currentKey", txtCurrentKey.Text);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            
                            string updateQuery = "UPDATE App_User SET Master_Key = @newKey";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@newKey", txtNewKey.Text);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Master Key updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                                txtCurrentKey.Clear();
                                txtNewKey.Clear();
                            }
                        }
                        else
                        {
                            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

            
            if (string.IsNullOrEmpty(txtPlatform.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields (Platform, Username, and Password)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string encryptedPassword = SecurityHelper.EncryptBase64(txtPassword.Text);

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    
                    string insertQuery = "INSERT INTO Vault_Data (PlatformName, Username, SavedPassword) VALUES (@platform, @username, @password)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@platform", txtPlatform.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", encryptedPassword); 

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Credential Saved Securely!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        txtPlatform.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.PasswordChar == '*')
            {
                
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Text = "Hide"; 
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowPassword.Text = "Show"; 
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            string pwd = txtPassword.Text;

            if (string.IsNullOrEmpty(pwd))
            {
                pbStrength.Value = 0;
                lblStrengthText.Text = "";
                return;
            }

            
            if (pwd.Length >= 8) score += 25;

           
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[A-Z]")) score += 25;

            
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[0-9]")) score += 25;

           
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[^a-zA-Z0-9]")) score += 25;

            
            pbStrength.Value = score;

            
            if (score <= 25)
            {
                lblStrengthText.Text = "Weak";
                lblStrengthText.ForeColor = System.Drawing.Color.Red;
            }
            else if (score == 50)
            {
                lblStrengthText.Text = "Fair";
                lblStrengthText.ForeColor = System.Drawing.Color.Orange;
            }
            else if (score == 75)
            {
                lblStrengthText.Text = "Good";
                lblStrengthText.ForeColor = System.Drawing.Color.Blue;
            }
            else if (score == 100)
            {
                lblStrengthText.Text = "Strong";
                lblStrengthText.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            string newPassword = "";

            
            Random rnd = new Random();

            for (int i = 0; i < 12; i++)
            {
                int index = rnd.Next(validChars.Length);
                newPassword += validChars[index];
            }

            
            txtPassword.Text = newPassword;

            txtPassword.PasswordChar = '\0';
        }

        private void txtNewKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            frmVault objVault = new frmVault();
            objVault.ShowDialog(); 
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
