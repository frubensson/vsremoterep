using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//*****************************
//Fabian Rubensson
//Programmering II 7,5 hp HT-11
//*****************************

namespace Biblioteksprojekt
{
    /// <summary>
    /// Form class representing a GUI for adding books.
    /// </summary>
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            context = BookService.GetInstance();
        }

        BookService context;
        
        Author authorToAdd = new Author();

        /// <summary>
        /// Adds a book to the library and checks if the author allready exists in the library (database)
        /// before it calls the method for adding the book (from the service layer).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book bookToAdd = new Book();
            bookToAdd.Book_ISBN = txtISBN.Text;
            bookToAdd.Book_Title = txtTitle.Text;
            bookToAdd.Book_Description = txtDescription.Text;

            Author tempAuthor = new Author();
            tempAuthor.Author_Name = txtBoxAuthorName.Text;
            List<string> authorNameList = new List<string>();

            foreach (var author in context.GetAllAuthors())
            {
                authorNameList.Add(author.Author_Name);
            }

            if (authorNameList.Contains(txtBoxAuthorName.Text))
            {
                bookToAdd.Author.Add(context.GetAllAuthors().First(x => x.Author_Name == txtBoxAuthorName.Text));
            }

            else
            {
                bookToAdd.Author.Add(tempAuthor);
            }
            
            context.AddBook(bookToAdd);
            txtBoxAuthorName.Clear();
            txtDescription.Clear();
            txtISBN.Clear();
            txtTitle.Clear();
        }

        /// <summary>
        /// Clear all textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtISBN.Clear();
            txtTitle.Clear();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
