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
    /// <summary>
    /// Service class that handles book loans to members.
    /// </summary>
    class LoanService
    {
        private static LoanService instance;

        /// <summary>
        /// Constructor
        /// </summary>
        private LoanService()
        {
            context = DBService.GetInstance();
            memberContext = MemberService.GetInstance();
        }

        LibraryDBEntities context;
        MemberService memberContext;

        public static LoanService GetInstance()
        {
            if (instance == null)
                instance = new LoanService();

            return instance;
        }

        /// <summary>
        /// Returns a collection of all loans in the library (Database).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> GetAllLoans()
        {
            return context.Loan;
        }

        /// <summary>
        /// Returns a loan object from the member id input.
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        private Loan GetLoanFromMember(int memberId)
        {
            var loan = context.Loan.SingleOrDefault((Loan b) => b.Member_Id == memberId);
            return loan;
        }

        /// <summary>
        /// Returns a loan object from the book id input.
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Loan GetLoanFromBookId(int bookId)
        {
            var loan = context.Loan.SingleOrDefault((Loan b) => b.Book_Copy_Id == bookId);
            return loan;
        }

        /// <summary>
        /// Method for adding a loan by tying a member object to a book object.
        /// </summary>
        /// <param name="memberToLoan"></param>
        /// <param name="bookToLoan"></param>
        public void LoanBook(Loan loan)
        {
            context.Book_Copy.Single(x => x.Book_Copy_Id == loan.Book_Copy_Id).Loaned = true;
            context.AddToLoan(loan);
            context.SaveChanges();
        }

        /// <summary>
        /// Method for returning a book from loan and calculates if there is a fine
        /// for books that are overdue.
        /// </summary>
        /// <param name="loanId"></param>
        public int ReturnBook(Loan loan)
        {
            context.Book_Copy.Single(x => x.Book_Copy_Id == loan.Book_Copy_Id).Loaned = false;//string todaysDate = DateTime.Now.ToShortDateString();
            int fine = 0;

            if (DateTime.Now > loan.Loan_Due_Date)
            {
                int finePerDay = 10;
                int daysOverdue = DateTime.Now.Subtract(loan.Loan_Due_Date).Days;
                fine = finePerDay * daysOverdue;
            }

            
            context.Loan.DeleteObject(loan);
            context.SaveChanges();

            return fine;
        }

        /// <summary>
        /// Method for extending a loan.
        /// </summary>
        /// <param name="specificLoan"></param>
        private void ExtendLoan(Loan specificLoan)
        {
            ReturnBook(specificLoan);
            LoanBook(specificLoan);
        }
    }

}
