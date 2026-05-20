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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVault));
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
            this.dgvVault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvVault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVault.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVault.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVault.EnableHeadersVisualStyles = false;
            this.dgvVault.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVault.Location = new System.Drawing.Point(14, 47);
            this.dgvVault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVault.Name = "dgvVault";
            this.dgvVault.RowHeadersVisible = false;
            this.dgvVault.RowHeadersWidth = 62;
            this.dgvVault.RowTemplate.Height = 28;
            this.dgvVault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVault.Size = new System.Drawing.Size(978, 420);
            this.dgvVault.TabIndex = 0;
            this.dgvVault.SelectionChanged += new System.EventHandler(this.dgvVault_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Platform Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(361, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(671, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtEditPlatform
            // 
            this.txtEditPlatform.Location = new System.Drawing.Point(147, 491);
            this.txtEditPlatform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditPlatform.Name = "txtEditPlatform";
            this.txtEditPlatform.Size = new System.Drawing.Size(207, 31);
            this.txtEditPlatform.TabIndex = 4;
            // 
            // txtEditUsername
            // 
            this.txtEditUsername.Location = new System.Drawing.Point(464, 495);
            this.txtEditUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditUsername.Name = "txtEditUsername";
            this.txtEditUsername.Size = new System.Drawing.Size(198, 31);
            this.txtEditUsername.TabIndex = 5;
            this.txtEditUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(769, 495);
            this.txtEditPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(180, 31);
            this.txtEditPassword.TabIndex = 6;
            // 
            // btnShowEditPwd
            // 
            this.btnShowEditPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowEditPwd.Location = new System.Drawing.Point(956, 495);
            this.btnShowEditPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowEditPwd.Name = "btnShowEditPwd";
            this.btnShowEditPwd.Size = new System.Drawing.Size(36, 34);
            this.btnShowEditPwd.TabIndex = 7;
            this.btnShowEditPwd.Text = "👁️";
            this.btnShowEditPwd.UseVisualStyleBackColor = true;
            this.btnShowEditPwd.Click += new System.EventHandler(this.btnShowEditPwd_Click);
            // 
            // btnVaultUpdate
            // 
            this.btnVaultUpdate.FlatAppearance.BorderSize = 0;
            this.btnVaultUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaultUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaultUpdate.ForeColor = System.Drawing.Color.Green;
            this.btnVaultUpdate.Location = new System.Drawing.Point(310, 580);
            this.btnVaultUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVaultUpdate.Name = "btnVaultUpdate";
            this.btnVaultUpdate.Size = new System.Drawing.Size(148, 40);
            this.btnVaultUpdate.TabIndex = 8;
            this.btnVaultUpdate.Text = "Update Record";
            this.btnVaultUpdate.UseVisualStyleBackColor = true;
            this.btnVaultUpdate.Click += new System.EventHandler(this.btnVaultUpdate_Click);
            // 
            // btnVaultDelete
            // 
            this.btnVaultDelete.FlatAppearance.BorderSize = 0;
            this.btnVaultDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaultDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaultDelete.ForeColor = System.Drawing.Color.Red;
            this.btnVaultDelete.Location = new System.Drawing.Point(507, 580);
            this.btnVaultDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVaultDelete.Name = "btnVaultDelete";
            this.btnVaultDelete.Size = new System.Drawing.Size(133, 40);
            this.btnVaultDelete.TabIndex = 9;
            this.btnVaultDelete.Text = "Delete Record";
            this.btnVaultDelete.UseVisualStyleBackColor = true;
            this.btnVaultDelete.Click += new System.EventHandler(this.btnVaultDelete_Click);
            // 
            // frmVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1004, 633);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
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