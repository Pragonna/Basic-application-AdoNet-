using ADO.NET_Console_CRUD_application.Entities.Common;


namespace ADO.NET_Console_CRUD_application.Entities
{
    public class Profession:BaseEntity
    {
        public string ProfessionName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
