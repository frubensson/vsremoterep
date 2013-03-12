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
    /// Loan manager form class.
    /// </summary>
    public partial class LoanManagerForm : Form
    {
        public LoanManagerForm()
        {
            InitializeComponent();
            bookContext = BookService.GetInstance();
            memberContext = MemberService.GetInstance();
            loanContext = LoanService.GetInstance();
            btnSearchBook.Click += new EventHandler(this.UpdateSearchListBox);
            UpdateMemberListBox();
            todaysDate = DateTime.Now.Date;
            dueDate = todaysDate.AddDays(15);
            ShowDates();
        }
        
        BookService bookContext;
        MemberService memberContext;
        LoanService loanContext;
        DateTime todaysDate;
        DateTime dueDate;

        private void ShowDates()
        {
            labelTodaysDate.Text = todaysDate.ToShortDateString();
            labelDueDate.Text = dueDate.ToShortDateString();
        }

        private void btnSearchBook_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Uppdates the listbox with member.
        /// </summary>
        private void UpdateMemberListBox()
        {
            listBoxMember.Items.Clear();
            listBoxMember.Items.Add("ID     Name");
            foreach (var member in memberContext.GetMembers())
            {
                listBoxMember.Items.Add(member.Member_Id.ToString() + "   " + member.Member_Name.ToString());
            }
        }

        /// <summary>
        /// Updates the search listbox depeding on if the search is made on ISBN, Author Name or Book Title. And if the
        /// User chooses to search only on book copies that are on loan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSearchListBox(object sender, EventArgs e)
        {
            listBoxBookSearchResult.Items.Clear();
            listBoxBookSearchResult.Items.Add("ID     Title");

            if (checkBoxOnLoan.Checked)
            {
                if (radioButtonTitle.Checked)
                {
                    foreach (var bookCopy in bookContext.UnAvailableBookCopies())
                    {
                        if (bookCopy.Book.Book_Title == textBoxBookSearch.Text)
                        {
                            listBoxBookSearchResult.Items.Add(bookCopy.Book_Copy_Id.ToString() + "    " + bookCopy.Book.Book_Title);
                        }
                    }
                }

                if (radioButtonISBN.Checked)
                {
                    foreach (var bookCopy in bookContext.UnAvailableBookCopies())
                    {
                        if (bookCopy.Book.Book_ISBN == textBoxBookSearch.Text)
                        {
                            listBoxBookSearchResult.Items.Add(bookCopy.Book_Copy_Id.ToString() + "    " + bookCopy.Book.Book_Title);
                        }
                    }
                }

                if (radioButtonAuthor.Checked)
                {
                    Author authorToSearch = new Author();
                    authorToSearch.Author_Name = textBoxBookSearch.Text;
                    IEnumerable<Book> bookcollectionFromAuthor;
                    bookcollectionFromAuthor = bookContext.BooksFromAuthor(authorToSearch);

                    foreach (var bookObject in bookcollectionFromAuthor)
                    {
                        foreach (var bookCopy in bookObject.Book_Copy)
                        {
                            if (bookCopy.Loaned == true)
                            {
                                listBoxBookSearchResult.Items.Add(bookCopy.Book_Copy_Id.ToString() + "      " + bookCopy.Book.Book_Title);
                            }
                        }
                    }
                }
            }

            else
            {
                //Creates a collection of all books that are avaliable for loan.
                IEnumerable<Book> avaliableBookCollection;
                avaliableBookCollection = bookContext.AvailableBooks();

                IEnumerable<Book_Copy> availableBookCopyCollection;
                availableBookCopyCollection = bookContext.AvailableBookCopies();

                if (radioButtonTitle.Checked)
                {
                    foreach (var bookCopy in availableBookCopyCollection)
                    {
                        if (bookCopy.Book.Book_Title == textBoxBookSearch.Text)
                        {
                            listBoxBookSearchResult.Items.Add(bookCopy.Book_Copy_Id.ToString() + "      " + bookCopy.Book.Book_Title);
                        }
                    }
                }

                if (radioButtonISBN.Checked)
                {
                    foreach (var bookCopy in availableBookCopyCollection)
                    {
                        if (bookCopy.Book.Book_ISBN == textBoxBookSearch.Text)
                        {
                            listBoxBookSearchResult.Items.Add(bookCopy.Book_Copy_Id.ToString() + "      " + bookCopy.Book.Book_Title);
                        }
                    }
                }

                if (radioButtonAuthor.Checked)
                {
                    Author authorToSearch = new Author();
                    authorToSearch.Author_Name = textBoxBookSearch.Text;
                    IEnumerable<Book> bookcollectionFromAuthor;
                    bookcollectionFromAuthor = bookContext.BooksFromAuthor(authorToSearch);

                    foreach (var bookObject in bookcollectionFromAuthor)
                    {
                        foreach (var bookCopy in bookObject.Book_Copy)
                        {
                            if (bookCopy.Loaned == false)
                            {
                                listBoxBookSearchResult.Items.Add(bookCopy.Book_Copy_Id.ToString() + "      " + bookCopy.Book.Book_Title);
                            }
                        }
                    }
                }
            }

            listBoxBookSearchResult.Update();
        }

        /// <summary>
        /// Checks when a book has it's due date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckDueDate_Click(object sender, EventArgs e)
        {
            int idToCheck = 0;
            
            if(!Int32.TryParse(textBoxWhenBookBeBack.Text, out idToCheck))
            {
                MessageBox.Show("Please enter numeric values");
            }

            Loan loanToCheckDueDate = loanContext.GetLoanFromBookId(idToCheck);
            labelWhenWillBookBeBack.Text = loanToCheckDueDate.Loan_Due_Date.ToShortDateString();
        }

        /// <summary>
        /// Creates a loan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            int loanBookCopyId;
            int loanMemberId;

            if (!Int32.TryParse(textBoxBookIdToLoan.Text, out loanBookCopyId))
            {
                MessageBox.Show("Please enter a numeric Copy ID");
                return;
            }

            if (!Int32.TryParse(textBoxMemberIdToLoan.Text, out loanMemberId))
            {
                MessageBox.Show("Please enter a numeric Copy ID");
                return;
            }

            Loan newLoanToCreate = new Loan();
            newLoanToCreate.Loan_Time_Of_Loan = todaysDate;
            newLoanToCreate.Loan_Due_Date = dueDate;
            newLoanToCreate.Member_Id = loanMemberId;
            newLoanToCreate.Book_Copy_Id = loanBookCopyId;
            loanContext.LoanBook(newLoanToCreate);

            textBoxBookIdToLoan.Clear();
            textBoxMemberIdToLoan.Clear();
        }

        /// <summary>
        /// Stupid name on the button. Sorry for that but this method removes a loan and shows if
        /// there is a fine to pay if the loan is over due.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int bookCopyIdForLoanToRemove;

            if (!Int32.TryParse(textBoxBookIdToLoan.Text, out bookCopyIdForLoanToRemove))
            {
                MessageBox.Show("Please enter a numeric book copy ID");
                return;
            }

            Loan loanToRemove = loanContext.GetAllLoans().Single(x => x.Book_Copy_Id == bookCopyIdForLoanToRemove);
            int possibleFine = loanContext.ReturnBook(loanToRemove);

            if (possibleFine > 0)
            {
                MessageBox.Show("The book is " + (possibleFine / 10).ToString() + " days overdue and the fine is " + possibleFine.ToString() + " SEK.");
            }

        }
    }
}
