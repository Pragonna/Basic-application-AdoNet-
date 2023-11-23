using ADO.NET_Console_CRUD_application.Context;
using ADO.NET_Console_CRUD_application.Entities;

namespace ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.ProfessionRepositories
{
    public class ProfessionWriteRepository : IWriteRepository<Profession>
    {
        private readonly SqlWriterContext professionContext;
        public ProfessionWriteRepository()
        {
            professionContext=new SqlWriterContext();
        }
        public void Delete(int id)
        {
            professionContext.ProfessionDeleteData(id);
        }

        public void Insert(Profession entity)
        {
            professionContext.ProfessionInsertData(entity.ProfessionName);
        }

        public void Modify(int id, Profession entity)
        {
            professionContext.ProfessionUpdateData(id, entity.ProfessionName);
        }
    }
}
