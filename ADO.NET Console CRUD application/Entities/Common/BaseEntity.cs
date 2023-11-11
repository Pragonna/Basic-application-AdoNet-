

namespace ADO.NET_Console_CRUD_application.Entities.Common
{
    public class BaseEntity
    {
        public int Id{ get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
