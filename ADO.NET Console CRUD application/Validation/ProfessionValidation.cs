using ADO.NET_Console_CRUD_application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Console_CRUD_application.Validation
{
    public static class ProfessionValidation
    {
        public static bool IsValid(Profession profession)
        {
            if (
                !string.IsNullOrEmpty(profession.ProfessionName)&&
                profession.ProfessionName.Length>1&&
                profession.ProfessionName.Length<20)
                return true;

            return false;
        }

        public static void ArgumentForIsNotValid()
        {
            Console.WriteLine("Profession name length must be between 1-20..");
        }
    }
}
