namespace Biblioteksprojekt
{
    partial class EditSelectedBookForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            this.txtBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.listBoxListAuthor = new System.Windows.Forms.ListBox();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemoveAuthor = new System.Windows.Forms.Button();
            this.groupBoxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Title";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(79, 78);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(239, 209);
            this.txtDescription.TabIndex = 13;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(79, 52);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(239, 20);
            this.txtISBN.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(79, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(239, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.btnRemoveAuthor);
            this.groupBoxAuthor.Controls.Add(this.txtBoxAddAuthor);
            this.groupBoxAuthor.Controls.Add(this.btnAddAuthor);
            this.groupBoxAuthor.Controls.Add(this.listBoxListAuthor);
            this.groupBoxAuthor.Location = new System.Drawing.Point(329, 5);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(301, 356);
            this.groupBoxAuthor.TabIndex = 14;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Author to Add or Remove";
            // 
            // txtBoxAddAuthor
            // 
            this.txtBoxAddAuthor.Location = new System.Drawing.Point(17, 294);
            this.txtBoxAddAuthor.Name = "txtBoxAddAuthor";
            this.txtBoxAddAuthor.Size = new System.Drawing.Size(268, 20);
            this.txtBoxAddAuthor.TabIndex = 2;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(17, 320);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(125, 23);
            this.btnAddAuthor.TabIndex = 1;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // listBoxListAuthor
            // 
            this.listBoxListAuthor.FormattingEnabled = true;
            this.listBoxListAuthor.Location = new System.Drawing.Point(17, 22);
            this.listBoxListAuthor.Name = "listBoxListAuthor";
            this.listBoxListAuthor.Size = new System.Drawing.Size(268, 264);
            this.listBoxListAuthor.TabIndex = 0;
            // 
            // numCopies
            // 
            this.numCopies.Location = new System.Drawing.Point(172, 294);
            this.numCopies.Name = "numCopies";
            this.numCopies.Size = new System.Drawing.Size(92, 20);
            this.numCopies.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of copies";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(79, 325);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(92, 23);
            this.btnUpdateBook.TabIndex = 17;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemoveAuthor
            // 
            this.btnRemoveAuthor.Location = new System.Drawing.Point(148, 320);
            this.btnRemoveAuthor.Name = "btnRemoveAuthor";
            this.btnRemoveAuthor.Size = new System.Drawing.Size(137, 23);
            this.btnRemoveAuthor.TabIndex = 3;
            this.btnRemoveAuthor.Text = "Remove Author";
            this.btnRemoveAuthor.UseVisualStyleBackColor = true;
            this.btnRemoveAuthor.Click += new System.EventHandler(this.btnRemoveAuthor_Click);
            // 
            // EditSelectedBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 376);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCopies);
            this.Controls.Add(this.groupBoxAuthor);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditSelectedBookForm";
            this.Text = "EditSelectedBookForm";
            this.groupBoxAuthor.ResumeLayout(false);
            this.groupBoxAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxAddAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ListBox listBoxListAuthor;
        private System.Windows.Forms.NumericUpDown numCopies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveAuthor;
    }
}