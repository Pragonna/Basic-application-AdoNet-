using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.ProfessionRepositories;
using ADO.NET_Console_CRUD_application.Validation;


namespace ADO.NET_Console_CRUD_application.Crud
{
    public class ProfessionCrud
    {
        private static ProfessionCrud instance = null;
        public static ProfessionCrud Instance=>instance?? (instance = new ProfessionCrud());

        private ProfessionWriteRepository professionWrite;
        private ProfessionReadRepository professionRead;

        private ProfessionCrud()
        {
            professionWrite=new ProfessionWriteRepository();
            professionRead=new ProfessionReadRepository();
        }

        private void GetProfessionFor(out Profession profession)
        {
            Console.Write("Profession name\t: ");
            var name = Console.ReadLine();

            profession = new Profession
            {
                ProfessionName = name
            };
        }

        public void Add()
        {
            Console.Clear();

            Profession profession;
            GetProfessionFor(out profession);

            if (ProfessionValidation.IsValid(profession))
            {
                professionWrite.Insert(profession);
                Console.Clear();
                Console.WriteLine("Profession has been successfully added.");
            }
            else
                ProfessionValidation.ArgumentForIsNotValid();

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

            Application.ProfessionOption();
        }

        public void Modify()
        {
            Console.Clear();
            Console.Write("Enter id that you want to modify: ");

            var tempId = Console.ReadLine();
            int id;
            if (!int.TryParse(tempId, out id))
            {
                Console.WriteLine("Please enter the correct number format\n");
                Console.WriteLine("Press any key to continue\nPress ESC to back main page");

                if (Console.ReadKey().Key is ConsoleKey.Escape)
                    Application.ProfessionOption();
                else
                    Modify();
            }

            var _profession=professionRead.FirstOrDefaultFocus(p => p.Id == id);
            if(_profession is null)
            {
                Console.WriteLine("This profession has been not found.\n\nPress any key to continue..");
                Console.ReadKey();
                Modify();
            }

            Console.WriteLine($"Id\t:{_profession.Id}\nProfession name\t: {_profession.ProfessionName}\n-----------------------\n");

            Profession profession;
            GetProfessionFor(out profession);

            if (ProfessionValidation.IsValid(profession))
            {
                professionWrite.Modify(id, profession);
                Console.WriteLine("Profession has been successfully updated..");
            }
            else
                ProfessionValidation.ArgumentForIsNotValid();

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

            
            Application.ProfessionOption();
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
                    Application.ProfessionOption();
                else
                    Delete();
            }

            var _profession = professionRead.FirstOrDefaultFocus(u => u.Id == id);

            if (_profession is null)
            {
                Console.WriteLine("This profession has been not found\n\nPress any key to continue");
                Console.ReadKey();
                Delete();
            }

            Console.WriteLine($"Id\t: {_profession.Id}Profession name\t: {_profession.ProfessionName}\nCreated date\t: {_profession.CreatedDate}\n\n--------------------------------------");

            Console.Write($"\n\n\n\t\t\t\t\tAre You Sure deleted User (Id: {_profession.Id}) ?\n\t\t\t\t\t   [Y]  or  [N] \n \t\t\t\t\t : ");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                professionWrite.Delete(id);
                Console.WriteLine($"\nId: {id} user has been successfully deleted\n\nPress any key to continue  ");
                Console.ReadKey();

            }
            else
                Delete();

            Application.ProfessionOption();
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
                    Application.ProfessionOption();
                else
                    GetById();
            }

            var profession = professionRead.FirstOrDefaultFocus(u => u.Id == id);
            if (profession is null)
            {
                Console.WriteLine("This profession has not been found");
                Console.WriteLine("Press any key to continue\nPress ESC to back main page...");
                if (Console.ReadKey().Key is ConsoleKey.Escape)
                    Application.ProfessionOption();
                else
                    GetById();
            }

            Console.Clear();

            Console.WriteLine($"Id\t: {profession.Id}\nName\t: {profession.ProfessionName}\n\n");
            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();

            Application.ProfessionOption();
        }

        public void GetAll()
        {
            Console.Clear();

            var professions = professionRead.GetAll();
            if (professions is null)
            {
                Console.WriteLine("Professions ` s table is a empty\n\nPress any key to continue  .. ");
                Console.ReadKey();
                Application.ProfessionOption();
            }
            int count = 0;

            foreach (var profession in professions)
            {
                count++;
                Console.WriteLine($"\t\t({count})\n\nId\t: {profession.Id}\nProfession name: {profession.ProfessionName}\nCreated date: {profession.CreatedDate}\n--------------------------------\n");

            }


            Console.WriteLine("Press any key to back Profession options");
            Console.ReadKey();

            Application.ProfessionOption();
        }
    }
}
