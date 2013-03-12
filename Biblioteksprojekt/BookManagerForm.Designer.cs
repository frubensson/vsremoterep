namespace Biblioteksprojekt
{
    partial class BookManagerForm
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.radioBtnPastDueDate = new System.Windows.Forms.RadioButton();
            this.radioBtnAvaliableBooks = new System.Windows.Forms.RadioButton();
            this.radioBtnAllBooks = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaunchEditBookForm = new System.Windows.Forms.Button();
            this.txtBoxBookToEditId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.textBoxDeleteBookId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(257, 334);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(148, 49);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Click here to add a new book to the database";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxBooks);
            this.groupBox1.Controls.Add(this.radioBtnPastDueDate);
            this.groupBox1.Controls.Add(this.radioBtnAvaliableBooks);
            this.groupBox1.Controls.Add(this.radioBtnAllBooks);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books in database";
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(150, 20);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxBooks.Size = new System.Drawing.Size(227, 277);
            this.listBoxBooks.TabIndex = 3;
            // 
            // radioBtnPastDueDate
            // 
            this.radioBtnPastDueDate.AutoSize = true;
            this.radioBtnPastDueDate.Location = new System.Drawing.Point(12, 68);
            this.radioBtnPastDueDate.Name = "radioBtnPastDueDate";
            this.radioBtnPastDueDate.Size = new System.Drawing.Size(123, 17);
            this.radioBtnPastDueDate.TabIndex = 2;
            this.radioBtnPastDueDate.Text = "Books past due date";
            this.radioBtnPastDueDate.UseVisualStyleBackColor = true;
            // 
            // radioBtnAvaliableBooks
            // 
            this.radioBtnAvaliableBooks.AutoSize = true;
            this.radioBtnAvaliableBooks.Location = new System.Drawing.Point(12, 45);
            this.radioBtnAvaliableBooks.Name = "radioBtnAvaliableBooks";
            this.radioBtnAvaliableBooks.Size = new System.Drawing.Size(100, 17);
            this.radioBtnAvaliableBooks.TabIndex = 1;
            this.radioBtnAvaliableBooks.Text = "Avaliable books";
            this.radioBtnAvaliableBooks.UseVisualStyleBackColor = true;
            // 
            // radioBtnAllBooks
            // 
            this.radioBtnAllBooks.AutoSize = true;
            this.radioBtnAllBooks.Location = new System.Drawing.Point(12, 22);
            this.radioBtnAllBooks.Name = "radioBtnAllBooks";
            this.radioBtnAllBooks.Size = new System.Drawing.Size(68, 17);
            this.radioBtnAllBooks.TabIndex = 0;
            this.radioBtnAllBooks.Text = "All books";
            this.radioBtnAllBooks.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnLaunchEditBookForm);
            this.groupBox2.Controls.Add(this.txtBoxBookToEditId);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book ID:";
            // 
            // btnLaunchEditBookForm
            // 
            this.btnLaunchEditBookForm.Location = new System.Drawing.Point(153, 20);
            this.btnLaunchEditBookForm.Name = "btnLaunchEditBookForm";
            this.btnLaunchEditBookForm.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchEditBookForm.TabIndex = 1;
            this.btnLaunchEditBookForm.Text = "Edit book";
            this.btnLaunchEditBookForm.UseVisualStyleBackColor = true;
            this.btnLaunchEditBookForm.Click += new System.EventHandler(this.btnLaunchEditBookForm_Click);
            // 
            // txtBoxBookToEditId
            // 
            this.txtBoxBookToEditId.Location = new System.Drawing.Point(71, 22);
            this.txtBoxBookToEditId.Name = "txtBoxBookToEditId";
            this.txtBoxBookToEditId.Size = new System.Drawing.Size(76, 20);
            this.txtBoxBookToEditId.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDeleteBookId);
            this.groupBox3.Controls.Add(this.btnDeleteBook);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 55);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID:";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(152, 20);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // textBoxDeleteBookId
            // 
            this.textBoxDeleteBookId.Location = new System.Drawing.Point(73, 22);
            this.textBoxDeleteBookId.Name = "textBoxDeleteBookId";
            this.textBoxDeleteBookId.Size = new System.Drawing.Size(73, 20);
            this.textBoxDeleteBookId.TabIndex = 2;
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddBook);
            this.Name = "BookManagerForm";
            this.Text = "Book Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.RadioButton radioBtnPastDueDate;
        private System.Windows.Forms.RadioButton radioBtnAvaliableBooks;
        private System.Windows.Forms.RadioButton radioBtnAllBooks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaunchEditBookForm;
        private System.Windows.Forms.TextBox txtBoxBookToEditId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDeleteBookId;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label label2;
    }
}