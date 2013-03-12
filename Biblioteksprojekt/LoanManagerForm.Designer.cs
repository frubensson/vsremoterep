namespace Biblioteksprojekt
{
    partial class LoanManagerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxMember = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxOnLoan = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxBookSearchResult = new System.Windows.Forms.ListBox();
            this.radioButtonAuthor = new System.Windows.Forms.RadioButton();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonISBN = new System.Windows.Forms.RadioButton();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.textBoxBookSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelWhenWillBookBeBack = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckDueDate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWhenBookBeBack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMemberIdToLoan = new System.Windows.Forms.TextBox();
            this.textBoxBookIdToLoan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelTodaysDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMember);
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All members in database";
            // 
            // listBoxMember
            // 
            this.listBoxMember.FormattingEnabled = true;
            this.listBoxMember.Location = new System.Drawing.Point(9, 16);
            this.listBoxMember.Name = "listBoxMember";
            this.listBoxMember.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMember.Size = new System.Drawing.Size(221, 238);
            this.listBoxMember.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxOnLoan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxBookSearchResult);
            this.groupBox2.Controls.Add(this.radioButtonAuthor);
            this.groupBox2.Controls.Add(this.radioButtonTitle);
            this.groupBox2.Controls.Add(this.radioButtonISBN);
            this.groupBox2.Controls.Add(this.btnSearchBook);
            this.groupBox2.Controls.Add(this.textBoxBookSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 262);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book search";
            // 
            // checkBoxOnLoan
            // 
            this.checkBoxOnLoan.AutoSize = true;
            this.checkBoxOnLoan.Location = new System.Drawing.Point(185, 45);
            this.checkBoxOnLoan.Name = "checkBoxOnLoan";
            this.checkBoxOnLoan.Size = new System.Drawing.Size(63, 17);
            this.checkBoxOnLoan.TabIndex = 7;
            this.checkBoxOnLoan.Text = "On loan";
            this.checkBoxOnLoan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search result (Book copy ID):";
            // 
            // listBoxBookSearchResult
            // 
            this.listBoxBookSearchResult.FormattingEnabled = true;
            this.listBoxBookSearchResult.Location = new System.Drawing.Point(7, 95);
            this.listBoxBookSearchResult.Name = "listBoxBookSearchResult";
            this.listBoxBookSearchResult.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxBookSearchResult.Size = new System.Drawing.Size(297, 160);
            this.listBoxBookSearchResult.TabIndex = 5;
            // 
            // radioButtonAuthor
            // 
            this.radioButtonAuthor.AutoSize = true;
            this.radioButtonAuthor.Location = new System.Drawing.Point(122, 45);
            this.radioButtonAuthor.Name = "radioButtonAuthor";
            this.radioButtonAuthor.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAuthor.TabIndex = 4;
            this.radioButtonAuthor.TabStop = true;
            this.radioButtonAuthor.Text = "Author";
            this.radioButtonAuthor.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(70, 45);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTitle.TabIndex = 3;
            this.radioButtonTitle.TabStop = true;
            this.radioButtonTitle.Text = "Title";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonISBN
            // 
            this.radioButtonISBN.AutoSize = true;
            this.radioButtonISBN.Checked = true;
            this.radioButtonISBN.Location = new System.Drawing.Point(13, 45);
            this.radioButtonISBN.Name = "radioButtonISBN";
            this.radioButtonISBN.Size = new System.Drawing.Size(50, 17);
            this.radioButtonISBN.TabIndex = 2;
            this.radioButtonISBN.TabStop = true;
            this.radioButtonISBN.Text = "ISBN";
            this.radioButtonISBN.UseVisualStyleBackColor = true;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(239, 18);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(66, 23);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // textBoxBookSearch
            // 
            this.textBoxBookSearch.Location = new System.Drawing.Point(7, 20);
            this.textBoxBookSearch.Name = "textBoxBookSearch";
            this.textBoxBookSearch.Size = new System.Drawing.Size(226, 20);
            this.textBoxBookSearch.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelWhenWillBookBeBack);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCheckDueDate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxWhenBookBeBack);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxMemberIdToLoan);
            this.groupBox3.Controls.Add(this.textBoxBookIdToLoan);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.labelDueDate);
            this.groupBox3.Controls.Add(this.labelTodaysDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCreateLoan);
            this.groupBox3.Location = new System.Drawing.Point(13, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 163);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loan";
            // 
            // labelWhenWillBookBeBack
            // 
            this.labelWhenWillBookBeBack.AutoSize = true;
            this.labelWhenWillBookBeBack.Location = new System.Drawing.Point(480, 93);
            this.labelWhenWillBookBeBack.Name = "labelWhenWillBookBeBack";
            this.labelWhenWillBookBeBack.Size = new System.Drawing.Size(0, 13);
            this.labelWhenWillBookBeBack.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Book will be back:";
            // 
            // btnCheckDueDate
            // 
            this.btnCheckDueDate.Location = new System.Drawing.Point(388, 63);
            this.btnCheckDueDate.Name = "btnCheckDueDate";
            this.btnCheckDueDate.Size = new System.Drawing.Size(143, 23);
            this.btnCheckDueDate.TabIndex = 15;
            this.btnCheckDueDate.Text = "Click to find out";
            this.btnCheckDueDate.UseVisualStyleBackColor = true;
            this.btnCheckDueDate.Click += new System.EventHandler(this.btnCheckDueDate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Copy ID:";
            // 
            // textBoxWhenBookBeBack
            // 
            this.textBoxWhenBookBeBack.Location = new System.Drawing.Point(388, 36);
            this.textBoxWhenBookBeBack.Name = "textBoxWhenBookBeBack";
            this.textBoxWhenBookBeBack.Size = new System.Drawing.Size(143, 20);
            this.textBoxWhenBookBeBack.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "When will the book be back?";
            // 
            // textBoxMemberIdToLoan
            // 
            this.textBoxMemberIdToLoan.Location = new System.Drawing.Point(92, 46);
            this.textBoxMemberIdToLoan.Name = "textBoxMemberIdToLoan";
            this.textBoxMemberIdToLoan.Size = new System.Drawing.Size(66, 20);
            this.textBoxMemberIdToLoan.TabIndex = 11;
            // 
            // textBoxBookIdToLoan
            // 
            this.textBoxBookIdToLoan.Location = new System.Drawing.Point(92, 17);
            this.textBoxBookIdToLoan.Name = "textBoxBookIdToLoan";
            this.textBoxBookIdToLoan.Size = new System.Drawing.Size(66, 20);
            this.textBoxBookIdToLoan.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(89, 106);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(35, 13);
            this.labelDueDate.TabIndex = 8;
            this.labelDueDate.Text = "label7";
            // 
            // labelTodaysDate
            // 
            this.labelTodaysDate.AutoSize = true;
            this.labelTodaysDate.Location = new System.Drawing.Point(89, 78);
            this.labelTodaysDate.Name = "labelTodaysDate";
            this.labelTodaysDate.Size = new System.Drawing.Size(35, 13);
            this.labelTodaysDate.TabIndex = 7;
            this.labelTodaysDate.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loan due date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Todays date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book copy ID:";
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(11, 134);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(100, 23);
            this.btnCreateLoan.TabIndex = 0;
            this.btnCreateLoan.Text = "Create loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // LoanManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoanManagerForm";
            this.Text = "Loan Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxBookSearchResult;
        private System.Windows.Forms.RadioButton radioButtonAuthor;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.RadioButton radioButtonISBN;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox textBoxBookSearch;
        private System.Windows.Forms.CheckBox checkBoxOnLoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelTodaysDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMemberIdToLoan;
        private System.Windows.Forms.TextBox textBoxBookIdToLoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWhenBookBeBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckDueDate;
        private System.Windows.Forms.Label labelWhenWillBookBeBack;
        private System.Windows.Forms.Label label8;
    }
}