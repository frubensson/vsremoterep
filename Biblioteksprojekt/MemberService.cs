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
    /// Service class that handles the members.
    /// </summary>
    public class MemberService
    {
        private static MemberService instance;

        //Constructor
        private MemberService()
        {
            context = DBService.GetInstance();
        }

        LibraryDBEntities context;

        public static MemberService GetInstance()
        {
            if (instance == null)
                instance = new MemberService();

            return instance;
        }

        /// <summary>
        /// Adds a member to the library (database).
        /// </summary>
        /// <param name="member"></param>
        public void AddMember(Member member)
        {
            context.AddToMember(member);
            context.SaveChanges();
        }

        /// <summary>
        /// Returns a member from the library (database).
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Member GetMember(int id)
        {
            var member = context.Member.SingleOrDefault((Member b) => b.Member_Id == id);
            return member;
        }

        /// <summary>
        /// Returns a member from the library (database).
        /// </summary>
        /// <param name="personalId"></param>
        /// <returns></returns>
        public Member GetMember(string personalId)
        {
            var member = context.Member.SingleOrDefault((Member b) => b.Member_Personal_Id == personalId);
            return member;
        }

        /// <summary>
        /// Returns a collection of all members from the library (database).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> GetMembers()
        {
            IEnumerable<Member> memberCollection = context.Member;
            return memberCollection;
        }
    }
}
