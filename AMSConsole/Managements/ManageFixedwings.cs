using AMSLibrary.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSConsole
{
    static class ManageFixedwings
    {
        static Managements managements = Managements.InitManagements(FilePath.airportsFile, FilePath.fixedwingsFile, FilePath.helicoptersFile);

        public static void ShowAllFixedwings()
        {
            try
            {
                Console.WriteLine(managements.AllFixedwings());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CreateNewFixedwing()
        {

        }
    }
}
