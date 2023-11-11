using ADO.NET_Console_CRUD_application.Context;
using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Console_CRUD_application.Repositories.EntitiesRepository.ProfessionRepositories
{
    public class ProfessionReadRepository : IReadRepository<Profession>
    {
        private readonly List<Profession> professions;
        public ProfessionReadRepository()
        {
            professions = new SqlReaderContext().ProfessionsReadData();
        }

        public Profession FindById(int id)
        {
            return professions.First(x => x.Id == id);
        }

        public Profession FirstOrDefaultFocus(Func<Profession, bool> predicate)
        {
            var profession =new SqlReaderContext().ProfessionsReadData().FirstOrDefault(predicate);

            if (profession is null)
                return default;

            return profession;
        }

        public IEnumerable<Profession> GetAll()
        {
            return new SqlReaderContext().ProfessionsReadData();
        }

        public IEnumerable<Profession> ToListByCreatedDateDescending()
        {
            return professions.OrderByDescending(p => p.CreatedDate);
        }

        public IEnumerable<Profession> WhereFocus(Func<Profession, bool> predicate)
        {
            return new SqlReaderContext().ProfessionsReadData().Where(predicate);
        }
    }
}
