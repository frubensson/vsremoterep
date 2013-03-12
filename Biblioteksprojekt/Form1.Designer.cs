namespace Biblioteksprojekt
{
    partial class Form1
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
            this.btnAddMemberForm = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnLoanManager = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPastDueDate = new System.Windows.Forms.Label();
            this.labelReturnToday = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMemberForm
            // 
            this.btnAddMemberForm.Location = new System.Drawing.Point(13, 42);
            this.btnAddMemberForm.Name = "btnAddMemberForm";
            this.btnAddMemberForm.Size = new System.Drawing.Size(102, 23);
            this.btnAddMemberForm.TabIndex = 1;
            this.btnAddMemberForm.Text = "Manage Members";
            this.btnAddMemberForm.UseVisualStyleBackColor = true;
            this.btnAddMemberForm.Click += new System.EventHandler(this.btnAddMemberForm_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(13, 13);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(101, 23);
            this.btnManageBooks.TabIndex = 2;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnLoanManager
            // 
            this.btnLoanManager.Location = new System.Drawing.Point(13, 71);
            this.btnLoanManager.Name = "btnLoanManager";
            this.btnLoanManager.Size = new System.Drawing.Size(101, 23);
            this.btnLoanManager.TabIndex = 3;
            this.btnLoanManager.Text = "Manage Loans";
            this.btnLoanManager.UseVisualStyleBackColor = true;
            this.btnLoanManager.Click += new System.EventHandler(this.btnLoanManager_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPastDueDate);
            this.groupBox1.Controls.Add(this.labelReturnToday);
            this.groupBox1.Controls.Add(this.labelAvailable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(131, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Library Statistics Monitoring Window";
            // 
            // labelPastDueDate
            // 
            this.labelPastDueDate.AutoSize = true;
            this.labelPastDueDate.Location = new System.Drawing.Point(149, 60);
            this.labelPastDueDate.Name = "labelPastDueDate";
            this.labelPastDueDate.Size = new System.Drawing.Size(35, 13);
            this.labelPastDueDate.TabIndex = 5;
            this.labelPastDueDate.Text = "label6";
            // 
            // labelReturnToday
            // 
            this.labelReturnToday.AutoSize = true;
            this.labelReturnToday.Location = new System.Drawing.Point(133, 43);
            this.labelReturnToday.Name = "labelReturnToday";
            this.labelReturnToday.Size = new System.Drawing.Size(35, 13);
            this.labelReturnToday.TabIndex = 4;
            this.labelReturnToday.Text = "label5";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(140, 26);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(35, 13);
            this.labelAvailable.TabIndex = 3;
            this.labelAvailable.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loans past their due dates:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loans due return today:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books available in library:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 113);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoanManager);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnAddMemberForm);
            this.Name = "Form1";
            this.Text = "Library System 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMemberForm;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnLoanManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPastDueDate;
        private System.Windows.Forms.Label labelReturnToday;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

