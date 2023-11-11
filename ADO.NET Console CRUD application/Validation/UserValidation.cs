using ADO.NET_Console_CRUD_application.Entities;


namespace ADO.NET_Console_CRUD_application.Validation
{
    public static class UserValidation
    {
       private static bool[] arr = new bool[6];

        public static bool IsValid(User user)
        {
            
            if (!string.IsNullOrEmpty(user.FirstName) && user.FirstName.Length < 20)
                arr[0] = true;
            if (!string.IsNullOrEmpty(user.LastName) && user.LastName.Length < 20)
                arr[1] = true;
            if ( !string.IsNullOrEmpty(user.Email) && user.Email.Contains('@'))
                arr[2] = true;
            if (user.Country is not null)
                arr[3] = true;
            if (user.Gender is not Entities.Common.GenderType.DEFAULT)
                arr[4] = true;
            if (user.ProfessionId > 0)
                arr[5] = true;

            foreach (var item in arr)
            {
                if (item is false)
                    return false;
            }

            return true;
        }

        public static void ArgumentForIsNotValid()
        {
            if (arr[0]is not true|| arr[1] is not true)
                Console.WriteLine("Please enter between correct character count: min. 1 - max. 20 ");
            if (arr[2]is not true)
                Console.WriteLine("Email address must be correct fill in the line");
            if (arr[3]is not true)
                Console.WriteLine("Enter the country");
            if (arr[4]is not true)
                Console.WriteLine("Enter the correct  option of gender");
            if (arr[5]is not true)
                Console.WriteLine("Enter the correct option of profession");
        }
    }
}
