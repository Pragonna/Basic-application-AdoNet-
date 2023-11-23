using ADO.NET_Console_CRUD_application.Context;
using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Repositories.Interfaces;


namespace ADO.NET_Console_CRUD_application.Repositories.Concured
{
    public class UserReadRepository : IReadRepository<User>
    {
        public User FindById(int id) => new SqlReaderContext().UserReadData().First(u => u.Id == id);

        public User FirstOrDefaultFocus(Func<User, bool> predicate) =>
            new SqlReaderContext().UserReadData().FirstOrDefault(predicate);

        public IEnumerable<User> WhereFocus(Func<User, bool> predicate) =>
            new SqlReaderContext().UserReadData().Where(predicate);

        public IEnumerable<User> GetAll() => new SqlReaderContext().UserReadData();


        public IEnumerable<UserProfession> GetFullUsers() => new SqlReaderContext().GetUserProfession();


        public IEnumerable<User> ToListByCreatedDateByDescending() =>
            new SqlReaderContext().UserReadData().OrderByDescending(u => u.CreatedDate).ToList();

    }
}
