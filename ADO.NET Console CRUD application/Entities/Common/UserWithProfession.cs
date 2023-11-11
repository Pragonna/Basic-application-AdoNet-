

namespace ADO.NET_Console_CRUD_application.Entities.Common
{
    public class UserWithProfession
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ProfessionName { get; set; }
        public DateTime DateTime { get; set; }
        public GenderType Gender { get; set; }

    }
}
