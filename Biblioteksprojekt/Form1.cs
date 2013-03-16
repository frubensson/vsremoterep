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
    public partial class Form1 : Form
    //{ commented out to introduce a build error
        /// <summary>
        /// Main form that is launched when the application is executed. Contains a monitoring window.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            contextDb = DBService.GetInstance();
            UpdateLibraryStatistics();
            contextDb.SavingChanges += new EventHandler(UpdateLibraryStatistics);
            contextDb.ObjectStateManager.ObjectStateManagerChanged += new CollectionChangeEventHandler(UpdateLibraryStatistics);
        }

        LibraryDBEntities contextDb;

        private void UpdateLibraryStatistics(object sender, EventArgs e)
        {
            UpdateLibraryStatistics();
        }

        /// <summary>
        /// Updates the statistics window.
        /// </summary>
        private void UpdateLibraryStatistics()
        {
            DateTime today = DateTime.Now.Date;
            labelAvailable.Text = contextDb.Book.Count().ToString();
            labelReturnToday.Text = contextDb.Loan.Where(x => x.Loan_Due_Date.CompareTo(today) == 0).Count().ToString();
            labelPastDueDate.Text = contextDb.Loan.Where(x => x.Loan_Due_Date.CompareTo(today) < 0).Count().ToString();
        }

        private void btnAddMemberForm_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.ShowDialog();
            addMemberForm.Focus();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BookManagerForm bookManagerForm = new BookManagerForm();
            bookManagerForm.ShowDialog();
            bookManagerForm.Focus();
        }

        private void btnLoanManager_Click(object sender, EventArgs e)
        {
            LoanManagerForm loanManager = new LoanManagerForm();
            loanManager.ShowDialog();
            loanManager.Focus();
        }
    }
}
