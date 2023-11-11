using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Entities.Common;
using ADO.NET_Console_CRUD_application.Repositories.Concured;
using ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.ProfessionRepositories;
using ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.UserRepositories;
using ADO.NET_Console_CRUD_application.Validation;


namespace ADO.NET_Console_CRUD_application.Crud
{
    public class UserCrud
    {
        // Singleton pattern

        private static UserCrud instance = null;
        public static UserCrud Instance => instance ??= new UserCrud();

        private UserWriteRepository userWrite;
        private UserReadRepository userRead;
        private ProfessionReadRepository professions;

        private UserCrud()
        {
            userWrite = new UserWriteRepository();
            userRead = new UserReadRepository();
            professions = new ProfessionReadRepository();
        }

        private void GetUserFromConsole(out User user)
        {
            Console.WriteLine("Press any key to continue..If you want to back Press - [ ESC ]");

            if (Console.ReadKey().Key == ConsoleKey.Escape)
                Application.UserOption();

            Console.Clear();

            Console.Write("First name\t: ");
            var firstName = Console.ReadLine();
            Console.Write("Last name\t: ");
            var lastName = Console.ReadLine();
            Console.Write("Day of birth\t: ");
            var tempDayOfBirth = Console.ReadLine();
            DateTime dayOfBirth;

            if (!DateTime.TryParse(tempDayOfBirth, out dayOfBirth))
            {
                Console.WriteLine("Please Enter the correct date time format (example: 01-01-1999 [between years:1753-2200])\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                GetUserFromConsole(out user);
            }


            Console.Write("Gender =>\n 1.Male\n 2.Female  =>  ");
            var gender = Console.ReadLine();
            var genderType = gender is "1" ? GenderType.Male : gender is "2" ? GenderType.Female : GenderType.DEFAULT;
            Console.Write("Country\t:");
            var country = Console.ReadLine();
            Console.Write("Email\t: ");
            var email = Console.ReadLine();

            int professionId = 0;
            Console.WriteLine("Select Profession =>");

            foreach (var p in professions.GetAll())
            {
                Console.WriteLine($"ID: {p.Id} -> PROFESSION: {p.ProfessionName} ");
            }

            var tempProfessionId = Console.ReadLine();
            int resultProfessionId;

            if (!int.TryParse(tempProfessionId, out resultProfessionId))
            {
                Console.WriteLine("Enter the correct option\n\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                GetUserFromConsole(out user);
            }

            foreach (var p in professions.GetAll())
            {
                if (resultProfessionId == p.Id)
                    professionId = p.Id;
            }


            user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dayOfBirth,
                Gender = genderType,
                Country = country,
                ProfessionId = professionId,
                Email = email
            };
        }

        public void Add()
        {
            Console.Clear();

            var profession = professions.GetAll();
            if (profession is null)
            {
                Console.WriteLine("Profession table is a empty. Please add first profession data before user add");
            }

            User user;
            GetUserFromConsole(out user);

            if (UserValidation.IsValid(user))
            {
                userWrite.Insert(user);
                Console.Clear();
                Console.WriteLine("\t\tUser has been added");
            }
            else
                UserValidation.ArgumentForIsNotValid();

            Console.WriteLine("\n Press any key to Back User`s section");
            Console.ReadKey();

            Application.UserOption();

        }

        public void Modify()
        {
            Console.Write("Enter id that you want to modify: ");

            var tempId = Console.ReadLine();
            int id;
            if (!int.TryParse(tempId, out id))
            {
                Console.WriteLine("Please enter the correct number format\n");
                Console.WriteLine("Press any key to continue\nPress ESC to back main page");

                if (Console.ReadKey().Key is ConsoleKey.Escape)
                    Application.UserOption();
                else
                    Modify();
            }

            var _user = userRead.FirstOrDefaultFocus(u => u.Id == id);

            if (_user is null)
            {
                Console.WriteLine("This user has been not found.\n\nPress any key to continue..");
                Console.ReadKey();
                Modify();
            }
            var profession = professions.FirstOrDefaultFocus(p => p.Id == _user.ProfessionId);

            Console.WriteLine($"First name\t: {_user.FirstName}\nLast name\t: {_user.LastName}\nCountry\t: {_user.Country}\nGender\t: {_user.Gender}\nDate of birth\t: {_user.DateOfBirth}\nProfession name\t: {profession.ProfessionName}\nCreated date\t: {profession.CreatedDate}\n\n--------------------------------------");


            User user;
            GetUserFromConsole(out user);
            user.Gender = _user.Gender;

            if (UserValidation.IsValid(user))
            {
                userWrite.Modify(id, user);
                Console.WriteLine("User has been successfully modified");
            }
            else
                UserValidation.ArgumentForIsNotValid();

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
            Application.UserOption();

        }

        public void Delete()
        {
            Console.Clear();

            Console.Write("Enter id that you want to delete: ");
            var tempId = Console.ReadLine();
            int id;
            if (!int.TryParse(tempId, out id))
            {
                Console.WriteLine("Please enter the correct number format.");
                Console.WriteLine("Press any key to continue\nPress ESC to back main page...");
                if (Console.ReadKey().Key is ConsoleKey.Escape)
                    Application.UserOption();
                else
                    Delete();
            }

            var _user = userRead.FirstOrDefaultFocus(u => u.Id == id);

            if (_user is null)
            {
                Console.WriteLine("This user has been not found\n\nPress any key to continue");
                Console.ReadKey();
                Delete();
            }
            var profession = professions.FirstOrDefaultFocus(p => p.Id == _user.ProfessionId);

            Console.WriteLine($"First name\t: {_user.FirstName}\nLast name\t: {_user.LastName}\nCountry\t: {_user.Country}\nGender\t: {_user.Gender}\nDate of birth\t: {_user.DateOfBirth}\nProfession name\t: {profession.ProfessionName}\nCreated date\t: {profession.CreatedDate}\n\n--------------------------------------");

            Console.Write($"\n\n\n\t\t\t\t\tAre You Sure deleted User (Id: {_user.Id}) ?\n\t\t\t\t\t   [Y]  or  [N] \n \t\t\t\t\t : ");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                userWrite.Delete(id);
                Console.WriteLine($"\nId: {id} user has been successfully deleted\n\nPress any key to continue  ");
                Console.ReadKey();

            }
            else
                Delete();

            Application.UserOption();
        }

        public void GetAll()
        {
            Console.Clear();

            var users = userRead.GetFullUsers();
            if (users is null)
            {
                Console.WriteLine("Users ` s table is a empty\n\nPress any key to continue  .. ");
                Console.ReadKey();
                Application.UserOption();
            }
            int count = 0;

            foreach (var user in users)
            {
                count++;
                Console.WriteLine($"\t({count})\nId: {user.Id}\nFirst name: {user.FirstName}\nLast name: {user.LastName}\nCountry: {user.Country}\nGender: {user.Gender}\nDate of birth: {user.DateTime}\nProfession: {user.ProfessionName}\nCreated date: {user.CreatedDate}\n===============================================\n");
            }


            Console.WriteLine("Press any key to back User options");
            Console.ReadKey();

            Application.UserOption();
        }

        public void GetById()
        {
            Console.Clear();

            Console.Write("Enter id that you want to find: ");
            var tempId = Console.ReadLine();
            int id;
            if (!int.TryParse(tempId, out id))
            {
                Console.WriteLine("Please enter the correct number format.");
                Console.WriteLine("Press any key to continue\nPress ESC to back main page...");
                if (Console.ReadKey().Key is ConsoleKey.Escape)
                    Application.UserOption();
                else
                    GetById();
            }

            var user = userRead.FirstOrDefaultFocus(u => u.Id == id);
            if (user is null)
            {
                Console.WriteLine("This user has not been found");
                Console.WriteLine("Press any key to continue\nPress ESC to back main page...");
                if (Console.ReadKey().Key is ConsoleKey.Escape)
                    Application.UserOption();
                else
                    GetById();
            }

            Console.Clear();

            var profession = professions.FirstOrDefaultFocus(p => p.Id == user.ProfessionId);

            Console.WriteLine($"\nFirst name: {user.FirstName}\nLast name: {user.LastName}\nCountry: {user.Country}\nGender: {user.Gender}\nDate of birth: {user.DateOfBirth}\nProfession: {profession.ProfessionName}\nCreated date: {user.CreatedDate}\n");

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();

            Application.UserOption();
        }

    }
}
