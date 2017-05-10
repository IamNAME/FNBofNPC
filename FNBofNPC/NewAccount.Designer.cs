namespace FNBofNPC
{
    partial class frmNewAccount
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
            this.saveAndExit_btn = new System.Windows.Forms.Button();
            this.AccountNum_tbx = new System.Windows.Forms.TextBox();
            this.CustomerID_tbx = new System.Windows.Forms.TextBox();
            this.savingsOrChecking_cbx = new System.Windows.Forms.ComboBox();
            this.startBalance_tbx = new System.Windows.Forms.TextBox();
            this.newAccountNumber_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountType_lb = new System.Windows.Forms.Label();
            this.startBal_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveAndExit_btn
            // 
            this.saveAndExit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndExit_btn.Location = new System.Drawing.Point(198, 237);
            this.saveAndExit_btn.Name = "saveAndExit_btn";
            this.saveAndExit_btn.Size = new System.Drawing.Size(173, 51);
            this.saveAndExit_btn.TabIndex = 0;
            this.saveAndExit_btn.Text = "Save and Exit";
            this.saveAndExit_btn.UseVisualStyleBackColor = true;
            this.saveAndExit_btn.Click += new System.EventHandler(this.saveAndExit_btn_Click);
            // 
            // AccountNum_tbx
            // 
            this.AccountNum_tbx.Enabled = false;
            this.AccountNum_tbx.Location = new System.Drawing.Point(231, 91);
            this.AccountNum_tbx.Name = "AccountNum_tbx";
            this.AccountNum_tbx.Size = new System.Drawing.Size(121, 20);
            this.AccountNum_tbx.TabIndex = 1;
            // 
            // CustomerID_tbx
            // 
            this.CustomerID_tbx.Location = new System.Drawing.Point(231, 120);
            this.CustomerID_tbx.Name = "CustomerID_tbx";
            this.CustomerID_tbx.Size = new System.Drawing.Size(121, 20);
            this.CustomerID_tbx.TabIndex = 2;
            // 
            // savingsOrChecking_cbx
            // 
            this.savingsOrChecking_cbx.FormattingEnabled = true;
            this.savingsOrChecking_cbx.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.savingsOrChecking_cbx.Location = new System.Drawing.Point(231, 146);
            this.savingsOrChecking_cbx.Name = "savingsOrChecking_cbx";
            this.savingsOrChecking_cbx.Size = new System.Drawing.Size(121, 21);
            this.savingsOrChecking_cbx.TabIndex = 3;
            // 
            // startBalance_tbx
            // 
            this.startBalance_tbx.Location = new System.Drawing.Point(230, 176);
            this.startBalance_tbx.Name = "startBalance_tbx";
            this.startBalance_tbx.Size = new System.Drawing.Size(121, 20);
            this.startBalance_tbx.TabIndex = 4;
            // 
            // newAccountNumber_lb
            // 
            this.newAccountNumber_lb.AutoSize = true;
            this.newAccountNumber_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountNumber_lb.Location = new System.Drawing.Point(27, 91);
            this.newAccountNumber_lb.Name = "newAccountNumber_lb";
            this.newAccountNumber_lb.Size = new System.Drawing.Size(168, 24);
            this.newAccountNumber_lb.TabIndex = 6;
            this.newAccountNumber_lb.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer ID";
            // 
            // accountType_lb
            // 
            this.accountType_lb.AutoSize = true;
            this.accountType_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountType_lb.Location = new System.Drawing.Point(27, 146);
            this.accountType_lb.Name = "accountType_lb";
            this.accountType_lb.Size = new System.Drawing.Size(140, 24);
            this.accountType_lb.TabIndex = 10;
            this.accountType_lb.Text = "Account Type";
            // 
            // startBal_lb
            // 
            this.startBal_lb.AutoSize = true;
            this.startBal_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBal_lb.Location = new System.Drawing.Point(27, 176);
            this.startBal_lb.Name = "startBal_lb";
            this.startBal_lb.Size = new System.Drawing.Size(161, 24);
            this.startBal_lb.TabIndex = 11;
            this.startBal_lb.Text = "Starting Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Account";
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(392, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBal_lb);
            this.Controls.Add(this.accountType_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newAccountNumber_lb);
            this.Controls.Add(this.startBalance_tbx);
            this.Controls.Add(this.savingsOrChecking_cbx);
            this.Controls.Add(this.CustomerID_tbx);
            this.Controls.Add(this.AccountNum_tbx);
            this.Controls.Add(this.saveAndExit_btn);
            this.Name = "frmNewAccount";
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndExit_btn;
        private System.Windows.Forms.TextBox AccountNum_tbx;
        private System.Windows.Forms.TextBox CustomerID_tbx;
        private System.Windows.Forms.ComboBox savingsOrChecking_cbx;
        private System.Windows.Forms.TextBox startBalance_tbx;
        private System.Windows.Forms.Label newAccountNumber_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountType_lb;
        private System.Windows.Forms.Label startBal_lb;
        private System.Windows.Forms.Label label1;
    }
}

