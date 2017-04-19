namespace FNBofNPC
{
    partial class frmTransaction
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
            this.transactionTypeCmBx = new System.Windows.Forms.ComboBox();
            this.fromAccountTbx = new System.Windows.Forms.TextBox();
            this.fromAccountLbl = new System.Windows.Forms.Label();
            this.amtLbl = new System.Windows.Forms.Label();
            this.amtTbx = new System.Windows.Forms.TextBox();
            this.toAccountLbl = new System.Windows.Forms.Label();
            this.toAccountTbx = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transactionTypeCmBx
            // 
            this.transactionTypeCmBx.FormattingEnabled = true;
            this.transactionTypeCmBx.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal",
            "Transfer"});
            this.transactionTypeCmBx.Location = new System.Drawing.Point(156, 72);
            this.transactionTypeCmBx.Name = "transactionTypeCmBx";
            this.transactionTypeCmBx.Size = new System.Drawing.Size(121, 21);
            this.transactionTypeCmBx.TabIndex = 0;
            this.transactionTypeCmBx.SelectedValueChanged += new System.EventHandler(this.transactionTypeCmBx_SelectedValueChanged);
            // 
            // fromAccountTbx
            // 
            this.fromAccountTbx.Location = new System.Drawing.Point(167, 139);
            this.fromAccountTbx.Name = "fromAccountTbx";
            this.fromAccountTbx.Size = new System.Drawing.Size(100, 20);
            this.fromAccountTbx.TabIndex = 1;
            this.fromAccountTbx.Visible = false;
            // 
            // fromAccountLbl
            // 
            this.fromAccountLbl.AutoSize = true;
            this.fromAccountLbl.Location = new System.Drawing.Point(177, 123);
            this.fromAccountLbl.Name = "fromAccountLbl";
            this.fromAccountLbl.Size = new System.Drawing.Size(86, 13);
            this.fromAccountLbl.TabIndex = 2;
            this.fromAccountLbl.Text = "From Account #:";
            this.fromAccountLbl.Visible = false;
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Location = new System.Drawing.Point(196, 185);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(46, 13);
            this.amtLbl.TabIndex = 4;
            this.amtLbl.Text = "Amount:";
            this.amtLbl.Visible = false;
            // 
            // amtTbx
            // 
            this.amtTbx.Location = new System.Drawing.Point(167, 201);
            this.amtTbx.Name = "amtTbx";
            this.amtTbx.Size = new System.Drawing.Size(100, 20);
            this.amtTbx.TabIndex = 3;
            this.amtTbx.Visible = false;
            // 
            // toAccountLbl
            // 
            this.toAccountLbl.AutoSize = true;
            this.toAccountLbl.Location = new System.Drawing.Point(177, 249);
            this.toAccountLbl.Name = "toAccountLbl";
            this.toAccountLbl.Size = new System.Drawing.Size(76, 13);
            this.toAccountLbl.TabIndex = 6;
            this.toAccountLbl.Text = "To Account #:";
            this.toAccountLbl.Visible = false;
            // 
            // toAccountTbx
            // 
            this.toAccountTbx.Location = new System.Drawing.Point(167, 265);
            this.toAccountTbx.Name = "toAccountTbx";
            this.toAccountTbx.Size = new System.Drawing.Size(100, 20);
            this.toAccountTbx.TabIndex = 5;
            this.toAccountTbx.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(178, 322);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.toAccountLbl);
            this.Controls.Add(this.toAccountTbx);
            this.Controls.Add(this.amtLbl);
            this.Controls.Add(this.amtTbx);
            this.Controls.Add(this.fromAccountLbl);
            this.Controls.Add(this.fromAccountTbx);
            this.Controls.Add(this.transactionTypeCmBx);
            this.Name = "frmTransaction";
            this.Text = "New Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox transactionTypeCmBx;
        private System.Windows.Forms.TextBox fromAccountTbx;
        private System.Windows.Forms.Label fromAccountLbl;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.TextBox amtTbx;
        private System.Windows.Forms.Label toAccountLbl;
        private System.Windows.Forms.TextBox toAccountTbx;
        private System.Windows.Forms.Button saveBtn;
    }
}

