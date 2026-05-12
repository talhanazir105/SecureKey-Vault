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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Aapki database ki connection string
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecureKeyVaultDB;Integrated Security=True";

            // Check karna ke koi dabba khali to nahi hai
            if (string.IsNullOrEmpty(txtPlatform.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields (Platform, Username, and Password)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yahan hum apna banaya hua SecurityHelper use karenge Password ko Encrypt karne ke liye
            string encryptedPassword = SecurityHelper.EncryptBase64(txtPassword.Text);

            // Database me Insert (Save) karne ka amal
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Database me data bhejny ki query
                    string insertQuery = "INSERT INTO Vault_Data (PlatformName, Username, SavedPassword) VALUES (@platform, @username, @password)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@platform", txtPlatform.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", encryptedPassword); // Asal nahi, Encrypt hua password bhej rahe hain

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Credential Saved Securely!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Save hone ke baad dabbe khud khali ho jayein taake naya data likha ja sake
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
            // Agar password chupa hua hai (*)
            if (txtPassword.PasswordChar == '*')
            {
                // Password show kar do (\0 ka matlab null/khali hota hai, jo star ko hata deta hai)
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Text = "Hide"; // Button ka text badal do
            }
            else
            {
                // Agar password pehle se nazar aa raha hai, to usay wapas chupa do
                txtPassword.PasswordChar = '*';
                btnShowPassword.Text = "Show"; // Button ka text wapas original kar do
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            string pwd = txtPassword.Text;

            // Agar password khali hai to meter 0 kar do
            if (string.IsNullOrEmpty(pwd))
            {
                pbStrength.Value = 0;
                lblStrengthText.Text = "";
                return;
            }

            // Length check (Kam se kam 8 haroof)
            if (pwd.Length >= 8) score += 25;

            // ABCD (Capital letters) check
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[A-Z]")) score += 25;

            // 1234 (Numbers) check
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[0-9]")) score += 25;

            // Special characters (!@#$) check
            if (System.Text.RegularExpressions.Regex.IsMatch(pwd, "[^a-zA-Z0-9]")) score += 25;

            // Meter ki line update karna
            pbStrength.Value = score;

            // Color aur Text change karna (Proposal ki requirement )
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
    }
}
