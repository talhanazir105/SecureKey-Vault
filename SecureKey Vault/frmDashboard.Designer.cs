namespace SecureKey_Vault
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeMasterKey = new System.Windows.Forms.Button();
            this.txtNewKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblStrengthText = new System.Windows.Forms.Label();
            this.pbStrength = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(118, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platform Name:";
            // 
            // txtPlatform
            // 
            this.txtPlatform.Location = new System.Drawing.Point(268, 145);
            this.txtPlatform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.Size = new System.Drawing.Size(234, 31);
            this.txtPlatform.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(102, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username/Email:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(268, 204);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 31);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(162, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(268, 276);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 31);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(167, 371);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Password";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerate.Location = new System.Drawing.Point(167, 434);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(419, 44);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Strong Password";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeMasterKey);
            this.groupBox1.Controls.Add(this.txtNewKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCurrentKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(658, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(306, 270);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Settings";
            // 
            // btnChangeMasterKey
            // 
            this.btnChangeMasterKey.BackColor = System.Drawing.Color.Green;
            this.btnChangeMasterKey.FlatAppearance.BorderSize = 0;
            this.btnChangeMasterKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMasterKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMasterKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeMasterKey.Location = new System.Drawing.Point(45, 198);
            this.btnChangeMasterKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeMasterKey.Name = "btnChangeMasterKey";
            this.btnChangeMasterKey.Size = new System.Drawing.Size(218, 51);
            this.btnChangeMasterKey.TabIndex = 4;
            this.btnChangeMasterKey.Text = "Update Master Key";
            this.btnChangeMasterKey.UseVisualStyleBackColor = false;
            this.btnChangeMasterKey.Click += new System.EventHandler(this.btnChangeMasterKey_Click);
            // 
            // txtNewKey
            // 
            this.txtNewKey.Location = new System.Drawing.Point(67, 144);
            this.txtNewKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewKey.Name = "txtNewKey";
            this.txtNewKey.PasswordChar = '*';
            this.txtNewKey.Size = new System.Drawing.Size(177, 31);
            this.txtNewKey.TabIndex = 3;
            this.txtNewKey.TextChanged += new System.EventHandler(this.txtNewKey_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(78, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Master Key:";
            // 
            // txtCurrentKey
            // 
            this.txtCurrentKey.Location = new System.Drawing.Point(67, 62);
            this.txtCurrentKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentKey.Name = "txtCurrentKey";
            this.txtCurrentKey.PasswordChar = '*';
            this.txtCurrentKey.Size = new System.Drawing.Size(177, 31);
            this.txtCurrentKey.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(63, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Master Key:";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(510, 276);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(44, 36);
            this.btnShowPassword.TabIndex = 11;
            this.btnShowPassword.Text = "👁️";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.SlateGray;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRead.Location = new System.Drawing.Point(445, 370);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(140, 44);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Read/View";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblStrengthText
            // 
            this.lblStrengthText.AutoSize = true;
            this.lblStrengthText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStrengthText.Location = new System.Drawing.Point(207, 315);
            this.lblStrengthText.Name = "lblStrengthText";
            this.lblStrengthText.Size = new System.Drawing.Size(0, 25);
            this.lblStrengthText.TabIndex = 13;
            this.lblStrengthText.Click += new System.EventHandler(this.label6_Click);
            // 
            // pbStrength
            // 
            this.pbStrength.Location = new System.Drawing.Point(271, 328);
            this.pbStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbStrength.Name = "pbStrength";
            this.pbStrength.Size = new System.Drawing.Size(233, 12);
            this.pbStrength.TabIndex = 14;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(978, 562);
            this.Controls.Add(this.pbStrength);
            this.Controls.Add(this.lblStrengthText);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecureKey Vault - Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeMasterKey;
        private System.Windows.Forms.TextBox txtNewKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentKey;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblStrengthText;
        private System.Windows.Forms.ProgressBar pbStrength;
    }
}