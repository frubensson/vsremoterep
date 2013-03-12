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
    public partial class EditSelectedBookForm : Form
    {
        /// <summary>
        /// Form for editing a selected book.
        /// </summary>
        /// <param name="bookToEditId"></param>
        public EditSelectedBookForm(int bookToEditId)
        {
            InitializeComponent();

            context = BookService.GetInstance();
            currentBook = context.GetBook(bookToEditId);
            ShowBooksInForms();
            ShowAuthors();
            btnAddAuthor.Click += new EventHandler(UpdateAuthorList);
            btnRemoveAuthor.Click += new EventHandler(UpdateAuthorList);
        }

        private BookService context;
        private Book currentBook;

        private void UpdateAuthorList(object sender, EventArgs e)
        {
            UpdateAuthorList();
        }

        /// <summary>
        /// Updates the listbox with authors that are added or removed. Is triggered
        /// by the event in the constructor.
        /// </summary>
        private void UpdateAuthorList()
        {
            listBoxListAuthor.Items.Clear();
            foreach (var item in currentBook.Author)
            {
                listBoxListAuthor.Items.Add(item.Author_Name.ToString());
            }
            listBoxListAuthor.Update();
        }

        /// <summary>
        /// Method that shows the info about the book that is to be edited in the text boxes.
        /// </summary>
        private void ShowBooksInForms()
        {
            txtTitle.Text = currentBook.Book_Title;
            txtISBN.Text = currentBook.Book_ISBN;
            txtDescription.Text = currentBook.Book_Description;
            numCopies.Value = currentBook.Book_Copy.Count();
        }

        /// <summary>
        /// Shows the authors connected to the book in the listbox.
        /// </summary>
        private void ShowAuthors()
        {
            try
            {
                listBoxListAuthor.Items.Clear();
                foreach (var author in currentBook.Author)
                {
                    listBoxListAuthor.Items.Add(author.Author_Name);
                }
                listBoxListAuthor.Update();
            }

            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Triggers the update of a specific book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            currentBook.Book_Title = txtTitle.Text;
            currentBook.Book_ISBN = txtISBN.Text;
            currentBook.Book_Description = txtDescription.Text;

            int numberOfCopiesToBe = Convert.ToInt32(numCopies.Value);
            int copiesBeforeEdit = currentBook.Book_Copy.Count();

            if (numberOfCopiesToBe > copiesBeforeEdit)
            {
                while (numberOfCopiesToBe > copiesBeforeEdit)
                {
                    Book_Copy tempBookCopy = new Book_Copy();
                    tempBookCopy.Book_id = currentBook.Book_Id;
                    currentBook.Book_Copy.Add(tempBookCopy);
                    numberOfCopiesToBe--;
                }
            }

            if (numberOfCopiesToBe < copiesBeforeEdit)
            {
                while (numberOfCopiesToBe < copiesBeforeEdit)
                {
                    context.DeleteBookCopy(context.GetAllBookCopies().Last(x => x.Book_id == currentBook.Book_Id && x.Loaned == false).Book_Copy_Id);
                    copiesBeforeEdit--;
                }
            }

            context.EditBook(currentBook);
        }

        /// <summary>
        /// Adds an author and checks if the author allready exists in the library.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author tempAuthor = new Author();
            tempAuthor.Author_Name = txtBoxAddAuthor.Text;
            List<string> authorNameList = new List<string>();

            foreach (var author in context.GetAllAuthors())
            {
                authorNameList.Add(author.Author_Name);
            }

            if (authorNameList.Contains(txtBoxAddAuthor.Text))
            {
                currentBook.Author.Add(context.GetAllAuthors().First(x => x.Author_Name == txtBoxAddAuthor.Text));
            }

            else
            {
                currentBook.Author.Add(tempAuthor);
            }

            txtBoxAddAuthor.Clear();
        }

        /// <summary>
        /// Triggers the removal of an author.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveAuthor_Click(object sender, EventArgs e)
        {
            currentBook.Author.Remove(currentBook.Author.ElementAt(listBoxListAuthor.SelectedIndex));
        }


    }
}
