using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*****************************
//Fabian Rubensson
//Programmering II 7,5 hp HT-11
//*****************************

namespace Biblioteksprojekt
{
    public class BookService
    {
        /// <summary>
        /// Service class that manages the books. Editing, adding etc..
        /// </summary>
        private static BookService instance;

        //Constructor
        private BookService()
        {
            context = DBService.GetInstance();
        }

        LibraryDBEntities context;
        List<Author> savedAuthors = new List<Author>();
        List<string> authorNameInDb = new List<string>();
        List<string> authorNameInBook = new List<string>();
        

        public static BookService GetInstance()
        {
            if (instance == null)
                instance = new BookService();

            return instance;
        }

        /// <summary>
        /// Get a specific book from the database based on it's id.
        /// </summary>
        /// <param name="id">int book id</param>
        /// <returns>A book object</returns>
        public Book GetBook(int id)
        {
            var book = context.Book.SingleOrDefault((Book b) => b.Book_Id == id);
            return book;
        }

        /// <summary>
        /// Get a specific book from the database based on it's ISBN.
        /// </summary>
        /// <param name="isbn">string ISBN</param>
        /// <returns>A book object</returns>
        public Book GetBookFromISBN(string isbn)
        {
            var book = context.Book.SingleOrDefault((Book b) => b.Book_ISBN == isbn);
            return book;
        }

        /// <summary>
        /// Get a specific book from the database based on it's Title.
        /// </summary>
        /// <param name="isbn">string Title</param>
        /// <returns>A book object</returns>
        public Book GetBookFromTitle(string title)
        {
            var book = context.Book.SingleOrDefault((Book b) => b.Book_Title == title);
            return book;
        }

        /// <summary>
        /// Return a collection of all books in the database.
        /// </summary>
        /// <returns>A collection of all books</returns>
        public IEnumerable<Book> GetBooks()
        {
            IEnumerable<Book> booklist = context.Book;
            return booklist;
        }

        /// <summary>
        /// Returns a collection of available books.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> AvailableBooks()
        {
            var bookCopyCollection = context.Book_Copy.Where((Book_Copy bc) => bc.Loaned == false);
            bookCopyCollection = bookCopyCollection.Distinct();
            List<Book> availableBookList = new List<Book>();
            foreach (var bookCopy in bookCopyCollection)
            {
                availableBookList.Add(context.Book.Single(x => x.Book_Id == bookCopy.Book_id));
            }

            return availableBookList;
        }

        /// <summary>
        /// Returns a collection of available book copies.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book_Copy> AvailableBookCopies()
        {
            return context.Book_Copy.Where((Book_Copy bc) => bc.Loaned == false);
        }

        /// <summary>
        /// Returns a collection of unavailable book copies.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book_Copy> UnAvailableBookCopies()
        {
            return context.Book_Copy.Where((Book_Copy bc) => bc.Loaned == true);
        }

        /// <summary>
        /// Returns a collection of books that are unavailable books.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> UnAvailableBooks()
        {
            var bookCopyCollection = context.Book_Copy.Where((Book_Copy bc) => bc.Loaned == true);
            bookCopyCollection = bookCopyCollection.Distinct();
            List<Book> unavailableBookList = new List<Book>();
            foreach (var bookCopy in bookCopyCollection)
            {
                unavailableBookList.Add(context.Book.Single(x => x.Book_Id == bookCopy.Book_id));
            }

            return unavailableBookList;
        }

        /// <summary>
        /// Returns a collection of books written by the author defined in the author object input.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Collection of books</returns>
        public IEnumerable<Book> BooksFromAuthor(Author name)
        {
            var author = context.Author.Single((Author a) => a.Author_Name == name.Author_Name); //Kan behöva ändras till First om inte marcus får till att author tabellen inte har 1000000 dubletter.

            List<Book> booksFromAuthor = new List<Book>();

            foreach (var bookInAuthor in author.Book)
            {
                booksFromAuthor.Add(bookInAuthor);
            }

            return booksFromAuthor;
        }

        /// <summary>
        /// Returns a collection of books that are past due-date.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> BooksPastDueDate()
        {
            DateTime todaysDate = DateTime.Now;

            var pastDueDateCollection = context.Loan.Where((Loan lo) => lo.Loan_Due_Date < todaysDate);
            List<Book_Copy> bookCopiesPastDueDate = new List<Book_Copy>();
            
            foreach(Loan item in pastDueDateCollection)
            {
                bookCopiesPastDueDate.Add(context.Book_Copy.Single((Book_Copy bc) => bc.Book_Copy_Id == item.Book_Copy_Id));
            }

            List<Book> booksPastDueDate = new List<Book>();

            foreach (Book_Copy item in bookCopiesPastDueDate)
            {
                booksPastDueDate.Add(context.Book.Where((Book b) => b.Book_Id == item.Book_id).First());
            }

            return booksPastDueDate;
        }

        /// <summary>
        /// Deletes a book from the library (Database).
        /// </summary>
        /// <param name="book"></param>
        public void DeleteBook(Book book)
        {
            context.DeleteObject(book);
            context.SaveChanges();
        }

        /// <summary>
        /// Adds a book to the library (Database).
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            context.Book.AddObject(book);
            context.SaveChanges();

            Book_Copy bookCopy = new Book_Copy();
            bookCopy.Book_id = book.Book_Id;
            book.Book_Copy.Add(bookCopy);

            context.SaveChanges();
        }

        /// <summary>
        /// Remove any authors in the database that has no book.
        /// </summary>
        public void CheckAndRemoveOverflowAuthors()
        {
            List<Book> overflowList = new List<Book>();

            foreach (var book in context.Book)
            {
                overflowList.Add(book);
            }

            foreach (var book in overflowList)
            {
                if (book.Book_Copy.Count() == 0)
                {
                    context.Book.DeleteObject(book);
                }
            }
        }

        /// <summary>
        /// Returns a collection of all authors in the library (Database).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Author> GetAllAuthors()
        {
            return context.Author;
        }

        /// <summary>
        /// Deletes a book copy from the library (Database).
        /// </summary>
        /// <param name="bookCopyId"></param>
        public void DeleteBookCopy(int bookCopyId)
        {
            context.Book_Copy.DeleteObject(context.Book_Copy.Single(x => x.Book_Copy_Id == bookCopyId));
            context.SaveChanges();
        }

        /// <summary>
        /// Returns a collection of all book copies in library (database).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book_Copy> GetAllBookCopies()
        {
            return context.Book_Copy;
        }

        /// <summary>
        /// Edits a existing book in the database.
        /// </summary>
        /// <param name="book"></param>
        public void EditBook(Book book)
        {
            context.Book.ApplyCurrentValues(book);
            context.SaveChanges();
        }
    }
    
}
