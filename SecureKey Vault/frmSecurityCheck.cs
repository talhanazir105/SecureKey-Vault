using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureKey_Vault
{
    public partial class frmSecurityCheck : Form
    {
        public bool IsVerified = false; 
        public frmSecurityCheck()
        {
            InitializeComponent();
        }

        private void btnVerifyPin_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
            string mySecretPin = "7860";

            if (txtSecretPin.Text == mySecretPin)
            {
                IsVerified = true;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Incorrect Security PIN! Access Denied.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecretPin.Clear();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void frmSecurityCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
