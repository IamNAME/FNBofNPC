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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionTypeCmBx
            // 
            this.transactionTypeCmBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeCmBx.FormattingEnabled = true;
            this.transactionTypeCmBx.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal",
            "Transfer"});
            this.transactionTypeCmBx.Location = new System.Drawing.Point(247, 56);
            this.transactionTypeCmBx.Name = "transactionTypeCmBx";
            this.transactionTypeCmBx.Size = new System.Drawing.Size(181, 32);
            this.transactionTypeCmBx.TabIndex = 0;
            this.transactionTypeCmBx.SelectedValueChanged += new System.EventHandler(this.transactionTypeCmBx_SelectedValueChanged);
            // 
            // fromAccountTbx
            // 
            this.fromAccountTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAccountTbx.Location = new System.Drawing.Point(247, 123);
            this.fromAccountTbx.Name = "fromAccountTbx";
            this.fromAccountTbx.Size = new System.Drawing.Size(181, 29);
            this.fromAccountTbx.TabIndex = 1;
            this.fromAccountTbx.Visible = false;
            // 
            // fromAccountLbl
            // 
            this.fromAccountLbl.AutoSize = true;
            this.fromAccountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAccountLbl.Location = new System.Drawing.Point(54, 123);
            this.fromAccountLbl.Name = "fromAccountLbl";
            this.fromAccountLbl.Size = new System.Drawing.Size(165, 24);
            this.fromAccountLbl.TabIndex = 2;
            this.fromAccountLbl.Text = "From Account #:";
            this.fromAccountLbl.Visible = false;
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLbl.Location = new System.Drawing.Point(131, 185);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(88, 24);
            this.amtLbl.TabIndex = 4;
            this.amtLbl.Text = "Amount:";
            this.amtLbl.Visible = false;
            // 
            // amtTbx
            // 
            this.amtTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtTbx.Location = new System.Drawing.Point(247, 185);
            this.amtTbx.Name = "amtTbx";
            this.amtTbx.Size = new System.Drawing.Size(181, 29);
            this.amtTbx.TabIndex = 3;
            this.amtTbx.Visible = false;
            // 
            // toAccountLbl
            // 
            this.toAccountLbl.AutoSize = true;
            this.toAccountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAccountLbl.Location = new System.Drawing.Point(78, 249);
            this.toAccountLbl.Name = "toAccountLbl";
            this.toAccountLbl.Size = new System.Drawing.Size(141, 24);
            this.toAccountLbl.TabIndex = 6;
            this.toAccountLbl.Text = "To Account #:";
            this.toAccountLbl.Visible = false;
            this.toAccountLbl.Click += new System.EventHandler(this.toAccountLbl_Click);
            // 
            // toAccountTbx
            // 
            this.toAccountTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAccountTbx.Location = new System.Drawing.Point(247, 249);
            this.toAccountTbx.Name = "toAccountTbx";
            this.toAccountTbx.Size = new System.Drawing.Size(181, 29);
            this.toAccountTbx.TabIndex = 5;
            this.toAccountTbx.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(258, 306);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 54);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Transaction";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(178)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

