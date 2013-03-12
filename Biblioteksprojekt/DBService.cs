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
    /// Class that represents a service layer for the database.
    /// </summary>
    public class DBService
    {
        private static LibraryDBEntities instance;

        private DBService()
        {

        }

        public static LibraryDBEntities GetInstance()
        {
            if (instance == null)
                instance = new LibraryDBEntities();

            return instance;
        }
    }
}
