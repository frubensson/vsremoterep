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
    /// Form class that handles the process of addind members to the library system.
    /// </summary>
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
            context = MemberService.GetInstance();
            UppdateMemberList();
            btnAddNewMember.Click +=new EventHandler(UppdateMemberList);
        }

        MemberService context;

        /// <summary>
        /// Calls the method to add a member and adds a member to the library (database).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            Member memberToAdd = new Member();
            
            //Nytt 2013-03-25: Kontroll som stoppar inmatningen ifall personnummer inte är 10-siffrigt utan bidestreck.
            if (txtMemberPersonalId.Text.Count() > 10)
            {
                MessageBox.Show("Du måste mata in personnummer med 10 siffror utan bindestreck");
                return;
            }
            else 
            {
                memberToAdd.Member_Personal_Id = txtMemberPersonalId.Text; //Medlemmen får ett personnummer tilldelat.
            }

            memberToAdd.Member_Name = txtMemberName.Text;
            memberToAdd.Member_Email = txtEmail.Text;

            context.AddMember(memberToAdd);

            txtEmail.Clear();
            txtMemberName.Clear();
            txtMemberPersonalId.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtMemberName.Clear();
            txtMemberPersonalId.Clear();
        }

        /// <summary>
        /// Method to update the listbox with all members in the library (database).
        /// </summary>
        private void UppdateMemberList()
        {
            listBoxMember.Items.Clear();
            listBoxMember.Items.Add("ID     Title");

            foreach (var member in context.GetMembers())
            {
                listBoxMember.Items.Add(member.Member_Id.ToString() + "       " + member.Member_Name.ToString());
            }
        }

        /// <summary>
        /// Method that is called by the event subscription in the constructor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UppdateMemberList(object sender, EventArgs e)
        {
            UppdateMemberList();
        }
    }
}
