namespace Coursework
{
    partial class UserNames
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
            this.lblAskUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAskUsername
            // 
            this.lblAskUsername.AutoSize = true;
            this.lblAskUsername.Location = new System.Drawing.Point(82, 65);
            this.lblAskUsername.Name = "lblAskUsername";
            this.lblAskUsername.Size = new System.Drawing.Size(130, 16);
            this.lblAskUsername.TabIndex = 0;
            this.lblAskUsername.Text = "Enter your username";
            this.lblAskUsername.Click += new System.EventHandler(this.lblAskUsername_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(590, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(123, 48);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // UserNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAskUsername);
            this.Name = "UserNames";
            this.Text = "UserNames";
            this.Load += new System.EventHandler(this.UserNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAskUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
    }
}