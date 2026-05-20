namespace SecureKey_Vault
{
    partial class frmSecurityCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecretPin = new System.Windows.Forms.TextBox();
            this.btnVerifyPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(200, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Admin Secret PIN:";
            // 
            // txtSecretPin
            // 
            this.txtSecretPin.Location = new System.Drawing.Point(409, 193);
            this.txtSecretPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecretPin.Name = "txtSecretPin";
            this.txtSecretPin.PasswordChar = '*';
            this.txtSecretPin.Size = new System.Drawing.Size(186, 31);
            this.txtSecretPin.TabIndex = 1;
            // 
            // btnVerifyPin
            // 
            this.btnVerifyPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVerifyPin.FlatAppearance.BorderSize = 0;
            this.btnVerifyPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyPin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyPin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerifyPin.Location = new System.Drawing.Point(431, 258);
            this.btnVerifyPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerifyPin.Name = "btnVerifyPin";
            this.btnVerifyPin.Size = new System.Drawing.Size(139, 42);
            this.btnVerifyPin.TabIndex = 2;
            this.btnVerifyPin.Text = "Verify";
            this.btnVerifyPin.UseVisualStyleBackColor = false;
            this.btnVerifyPin.Click += new System.EventHandler(this.btnVerifyPin_Click);
            // 
            // frmSecurityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.btnVerifyPin);
            this.Controls.Add(this.txtSecretPin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSecurityCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Verification";
            this.Load += new System.EventHandler(this.frmSecurityCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecretPin;
        private System.Windows.Forms.Button btnVerifyPin;
    }
}