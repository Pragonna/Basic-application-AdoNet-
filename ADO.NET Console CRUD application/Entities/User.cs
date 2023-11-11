using ADO.NET_Console_CRUD_application.Entities.Common;


namespace ADO.NET_Console_CRUD_application.Entities
{
    public class User:BaseEntity
    {
        public int ProfessionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string Country { get; set; }
        public Profession Profession { get; set; }
        public bool IsFemale { get; set; }
        public GenderType Gender { get; set; }
    }
}
