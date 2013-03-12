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
    public partial class BookManagerForm : Form
    {
        /// <summary>
        /// Form for managing books and launches both the add- and edit book forms.
        /// </summary>
        public BookManagerForm()
        {
            InitializeComponent();
            contextBookService = BookService.GetInstance();
            UpdateList();
            radioBtnAllBooks.CheckedChanged += new EventHandler(UpdateList);
            radioBtnAvaliableBooks.CheckedChanged += new EventHandler(UpdateList);
            radioBtnPastDueDate.CheckedChanged += new EventHandler(UpdateList);
            radioBtnAllBooks.Checked = true;
        }

        private BookService contextBookService;

        /// <summary>
        /// Launches the add book form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            addBookForm.Focus();
        }

        /// <summary>
        /// Launches the edit book form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLaunchEditBookForm_Click(object sender, EventArgs e)
        {
            int result;
            if (!Int32.TryParse(txtBoxBookToEditId.Text, out result))
            {
                MessageBox.Show("You have to enter a Book ID to be able to edit a book. \nPlease enter a valid book ID and try again.");
                return;
            }

            EditSelectedBookForm editSelectedBookForm = new EditSelectedBookForm(result);
            editSelectedBookForm.ShowDialog();
            editSelectedBookForm.Focus();
        }

        /// <summary>
        /// Calls the delete method from the service layer to delete a book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {

                int bookIdForDeletion = 0;
                if (!Int32.TryParse(textBoxDeleteBookId.Text, out bookIdForDeletion))
                {
                    MessageBox.Show("You have to enter a Book ID to be able to delete a book. \nPlease enter a valid book ID and try again.");
                    return;
                }

                if (bookIdForDeletion > 0)
                {
                    contextBookService.DeleteBook(contextBookService.GetBooks().Single(x => x.Book_Id == bookIdForDeletion));
                    MessageBox.Show("Book sucsessfully deleted");
                }

            }

            catch { MessageBox.Show("Book could not be deleted.\nHave you entered a correct Book ID?"); }

        }

        /// <summary>
        /// Updates the listbox when the form is launched (through the event subscription in the constructor).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateList(object sender, EventArgs e)
        {
            UpdateList();
        }

        /// <summary>
        /// Updates the listbox.
        /// </summary>
        private void UpdateList()
        {
            listBoxBooks.Items.Clear();
            listBoxBooks.Items.Add("ID     Title");
            try
            {

                if (radioBtnAllBooks.Checked)
                {
                    foreach (var book in contextBookService.GetBooks())
                    {
                        listBoxBooks.Items.Add(book.Book_Id.ToString() + "   " + book.Book_Title);
                    }
                }

                if (radioBtnAvaliableBooks.Checked)
                {
                    listBoxBooks.Items.Clear();
                    listBoxBooks.Items.Add("ID     Copy ID        Title");
                    foreach (var bookCopy in contextBookService.AvailableBookCopies())
                    {
                        
                            listBoxBooks.Items.Add(bookCopy.Book_id.ToString() + "       " + bookCopy.Book_Copy_Id.ToString() + "                   " + bookCopy.Book.Book_Title);
                       
                    }
                }

                if (radioBtnPastDueDate.Checked)
                {
                    listBoxBooks.Items.Clear();
                    foreach (var book in contextBookService.BooksPastDueDate())
                    {
                        foreach (var bookCopy in book.Book_Copy)
                        {
                            listBoxBooks.Items.Add(book.Book_Title.ToString() + " Book Copy ID: " + bookCopy.Book_Copy_Id.ToString());
                        }
                    }
                }

            }

            catch { }

            listBoxBooks.Update();
        }
    }
}
