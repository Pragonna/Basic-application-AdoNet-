using ADO.NET_Console_CRUD_application.Crud;


namespace ADO.NET_Console_CRUD_application
{
    public class Application
    {

        public Application()
        {
        }

        public void Run()
        {
            StartApplication();
        }

        private static void StartApplication()
        {
            Console.Clear();
            Console.WriteLine("\t\tSELECT ENTITY\n");
            Console.WriteLine(" 1. USER   \t\t\t  2. PROFESSION\n\t\t3. EXIT");
            Console.Write("\n => ");
            var consoleOption = Console.ReadLine();

            switch (consoleOption)
            {
                case "1":
                    UserOption();
                    break;
                case "2":
                    ProfessionOption();
                    break;
                case "3":
                    return;
                default:
                    StartApplication();
                    break;
            }
        }

        public static void UserOption()
        {
            var instance = UserCrud.Instance;

            Console.Clear();
            Console.WriteLine("1. ADD USER\t\t2. MODIFY USER\t\t3. DELETE USER\n4. GET ALL USER\t\t5. GET USER BY ID\t6.BACK TO MAIN ");
            Console.Write("\n => ");
            var consoleOption = Console.ReadLine();

            switch (consoleOption)
            {
                case "1":
                    instance.Add();
                    break;
                case "2":
                    instance.Modify();
                    break;
                case "3":
                    instance.Delete();
                    break;
                case "4":
                    instance.GetAll();
                    break;
                case "5":
                    instance.GetById();
                    break;
                case "6":
                    StartApplication();
                    break;
                default:
                    UserOption();
                    //
                    break;
            }

        }

        public static void ProfessionOption()
        {
            var instance = ProfessionCrud.Instance;

            Console.Clear();
            Console.WriteLine("1. ADD PROFESSION\t\t2. MODIFY PROFESSION\t\t3. DELETE PROFESSION\n4. GET ALL PROFESSION\t\t5. GET PROFESSION BY ID\t\t6.BACK TO MAIN ");
            Console.Write("\n => ");
            var consoleOption = Console.ReadLine();

            switch (consoleOption)
            {
                case "1":
                    instance.Add();
                    break;
                case "2":
                    instance.Modify();
                    break;
                case "3":
                    instance.Delete();
                    break;
                case "4":
                    instance.GetAll();
                    break;
                case "5":
                    instance.GetById();
                    break;
                case "6":
                    StartApplication();
                    break;
                default:
                    ProfessionOption();
                    break;
            }
        }
    }
}
