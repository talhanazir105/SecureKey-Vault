namespace SecureKey_Vault
{
    partial class frmVault
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVault = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditPlatform = new System.Windows.Forms.TextBox();
            this.txtEditUsername = new System.Windows.Forms.TextBox();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.btnShowEditPwd = new System.Windows.Forms.Button();
            this.btnVaultUpdate = new System.Windows.Forms.Button();
            this.btnVaultDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVault)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVault
            // 
            this.dgvVault.AllowUserToAddRows = false;
            this.dgvVault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVault.Location = new System.Drawing.Point(12, 43);
            this.dgvVault.Name = "dgvVault";
            this.dgvVault.RowHeadersVisible = false;
            this.dgvVault.RowHeadersWidth = 62;
            this.dgvVault.RowTemplate.Height = 28;
            this.dgvVault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVault.Size = new System.Drawing.Size(867, 336);
            this.dgvVault.TabIndex = 0;
            this.dgvVault.SelectionChanged += new System.EventHandler(this.dgvVault_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Platform Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtEditPlatform
            // 
            this.txtEditPlatform.Location = new System.Drawing.Point(132, 393);
            this.txtEditPlatform.Name = "txtEditPlatform";
            this.txtEditPlatform.Size = new System.Drawing.Size(187, 26);
            this.txtEditPlatform.TabIndex = 4;
            // 
            // txtEditUsername
            // 
            this.txtEditUsername.Location = new System.Drawing.Point(418, 396);
            this.txtEditUsername.Name = "txtEditUsername";
            this.txtEditUsername.Size = new System.Drawing.Size(179, 26);
            this.txtEditUsername.TabIndex = 5;
            this.txtEditUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(692, 396);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(162, 26);
            this.txtEditPassword.TabIndex = 6;
            // 
            // btnShowEditPwd
            // 
            this.btnShowEditPwd.Location = new System.Drawing.Point(860, 396);
            this.btnShowEditPwd.Name = "btnShowEditPwd";
            this.btnShowEditPwd.Size = new System.Drawing.Size(18, 27);
            this.btnShowEditPwd.TabIndex = 7;
            this.btnShowEditPwd.Text = "👁️";
            this.btnShowEditPwd.UseVisualStyleBackColor = true;
            this.btnShowEditPwd.Click += new System.EventHandler(this.btnShowEditPwd_Click);
            // 
            // btnVaultUpdate
            // 
            this.btnVaultUpdate.Location = new System.Drawing.Point(279, 464);
            this.btnVaultUpdate.Name = "btnVaultUpdate";
            this.btnVaultUpdate.Size = new System.Drawing.Size(133, 32);
            this.btnVaultUpdate.TabIndex = 8;
            this.btnVaultUpdate.Text = "Update Record";
            this.btnVaultUpdate.UseVisualStyleBackColor = true;
            this.btnVaultUpdate.Click += new System.EventHandler(this.btnVaultUpdate_Click);
            // 
            // btnVaultDelete
            // 
            this.btnVaultDelete.Location = new System.Drawing.Point(456, 464);
            this.btnVaultDelete.Name = "btnVaultDelete";
            this.btnVaultDelete.Size = new System.Drawing.Size(120, 32);
            this.btnVaultDelete.TabIndex = 9;
            this.btnVaultDelete.Text = "Delete Record";
            this.btnVaultDelete.UseVisualStyleBackColor = true;
            this.btnVaultDelete.Click += new System.EventHandler(this.btnVaultDelete_Click);
            // 
            // frmVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 527);
            this.Controls.Add(this.btnVaultDelete);
            this.Controls.Add(this.btnVaultUpdate);
            this.Controls.Add(this.btnShowEditPwd);
            this.Controls.Add(this.txtEditPassword);
            this.Controls.Add(this.txtEditUsername);
            this.Controls.Add(this.txtEditPlatform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVault);
            this.Name = "frmVault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Secure Vault";
            this.Load += new System.EventHandler(this.frmVault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditPlatform;
        private System.Windows.Forms.TextBox txtEditUsername;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.Button btnShowEditPwd;
        private System.Windows.Forms.Button btnVaultUpdate;
        private System.Windows.Forms.Button btnVaultDelete;
    }
}