using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Biblioteksprojekt.UnitTests
{
    [TestFixture()]
    public class UnitTests
    {
        MemberService context;
        public UnitTests()
        {
            context = MemberService.GetInstance();
        }

        [Test]
        public void MemberEqualityCheck()
        {
            //Skapar en användare att lägga till i databasen
            Member testMember = new Member();
            testMember.Member_Personal_Id = "8306130231";
            testMember.Member_Name = "Fabian Rubensson";
            testMember.Member_Email = "fabian.rubensson@sogeti.se";
            context.AddMember(testMember);

            //Hämtar användaren som vi skapat och sparar den till ett nytt objekt.
            Member parsedMember = new Member();
            parsedMember = context.GetMember("8306130231");

            //Jämför de två memberobjekten med varandra.
            Assert.AreEqual(testMember, parsedMember);
        }
    }
}
