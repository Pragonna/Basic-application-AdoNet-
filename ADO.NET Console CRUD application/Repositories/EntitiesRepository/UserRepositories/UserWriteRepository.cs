using ADO.NET_Console_CRUD_application.Context;
using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Enums;

namespace ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.UserRepositories
{
    public class UserWriteRepository : IWriteRepository<User>
    {
        private  readonly SqlWriterContext userContext;

        public UserWriteRepository()
        {
            userContext = new SqlWriterContext();
        }
        public void Insert(User entity)
        {
            bool isFemale = false;

            if (entity.Gender is GenderType.Female)
                isFemale = true;

            userContext.UserInsertData(
                entity.FirstName,
                entity.LastName,
                entity.Country,
                entity.DateOfBirth,
                entity.Email, isFemale,
                entity.ProfessionId);
        }


        public void Modify(int id, User entity)
        {
            userContext.UserUpdateData(
                id,
                entity.FirstName,
                entity.LastName,
                entity.DateOfBirth,
                entity.Country,
                entity.Email,
                entity.ProfessionId);
        }
        public void Delete(int id)
        {
            userContext.UserDeleteData(id);
        }

    }
}
