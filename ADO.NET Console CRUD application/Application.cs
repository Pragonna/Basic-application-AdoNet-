using ADO.NET_Console_CRUD_application.Crud;
using ADO.NET_Console_CRUD_application.Enums;


namespace ADO.NET_Console_CRUD_application
{

    public class Application
    {
        public  delegate void OptionMethod();

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
            int select;
            var consoleOption = int.TryParse(Console.ReadLine(),out select);

            if (!consoleOption)
                return;

            switch (select)
            {
                case (int)SelectType.UserOption:
                    UserOption();
                    break;
                case (int)SelectType.ProfessionOption:
                    ProfessionOption();
                    break;
                case (int)SelectType.Exit:
                    return;
                default:
                    StartApplication();
                    break;
            }
        }

        public static void UserOption()
        {
            var instance = UserCrud.Instance;
            GetOption(instance,UserOption);
        }

        public static void ProfessionOption()
        {
            var instance = ProfessionCrud.Instance;
            GetOption(instance,ProfessionOption);
        }
        private static void GetOption(ICrud instance,OptionMethod option)
        {

            Console.Clear();
            Console.WriteLine("1. ADD USER\t\t2. MODIFY USER\t\t3. DELETE USER\n4. GET ALL USER\t\t5. GET USER BY ID\t6.BACK TO MAIN ");
            Console.Write("\n => ");
            int select;
            var consoleOption = int.TryParse(Console.ReadLine(), out select);

            if (!consoleOption)
                return;

            switch (select)
            {
                case (int)GetFunction.Add:
                    instance.Add();
                    break;
                case (int)GetFunction.Modify:
                    instance.Modify();
                    break;
                case (int)GetFunction.Delete:
                    instance.Delete();
                    break;
                case (int)GetFunction.GetAll:
                    instance.GetAll();
                    break;
                case (int)GetFunction.GetById:
                    instance.GetById();
                    break;
                case (int)GetFunction.StartApplication:
                    StartApplication();
                    break;
                default:
                    option();
                    break;
            }
        }
    }
}
