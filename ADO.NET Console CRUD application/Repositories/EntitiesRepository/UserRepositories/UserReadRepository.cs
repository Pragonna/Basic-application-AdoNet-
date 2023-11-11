using ADO.NET_Console_CRUD_application.Context;
using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Entities.Common;
using ADO.NET_Console_CRUD_application.Repositories.Interfaces;


namespace ADO.NET_Console_CRUD_application.Repositories.Concured
{
    public class UserReadRepository : IReadRepository<User>
    {
        private readonly List<User> users;
        private readonly List<UserWithProfession> userWithProfessions;

        public UserReadRepository()
        {
            users =new SqlReaderContext().UserReadData();
            userWithProfessions = new SqlReaderContext().GetUserProfession();
        }

        public User FindById(int id)
        {
            return users.First(u => u.Id == id);
        }

        public User FirstOrDefaultFocus(Func<User, bool> predicate)
        {
            var user= new SqlReaderContext().UserReadData().FirstOrDefault(predicate);

            if (user is null)
                return default;

            return user;
        }

        public IEnumerable<User> WhereFocus(Func<User, bool> predicate)
        {
            return new SqlReaderContext().UserReadData().Where(predicate);
        }
       public IEnumerable<User> GetAll()
        {
            return new SqlReaderContext().UserReadData();
        }

        public IEnumerable<UserWithProfession> GetFullUsers()
        {
            return new SqlReaderContext().GetUserProfession();
        }

        public IEnumerable<User> ToListByCreatedDateDescending()
        {
            return users.OrderByDescending(u => u.CreatedDate).ToList();
        }
    }
}
