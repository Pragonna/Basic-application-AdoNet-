using ADO.NET_Console_CRUD_application.Context;
using ADO.NET_Console_CRUD_application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.ProfessionRepositories
{
    public class ProfessionWriteRepository : IWriteRepository<Profession>
    {
        private SqlWriterContext professionContext;
        public ProfessionWriteRepository()
        {
            professionContext=SqlWriterContext.Instance;
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
