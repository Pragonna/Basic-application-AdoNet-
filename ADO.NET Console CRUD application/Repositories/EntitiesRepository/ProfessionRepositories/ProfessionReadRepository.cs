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
        public Profession FindById(int id) =>
            new SqlReaderContext().ProfessionsReadData().First(x => x.Id == id);

        public Profession FirstOrDefaultFocus(Func<Profession, bool> predicate) =>
            new SqlReaderContext().ProfessionsReadData().FirstOrDefault(predicate);

        public IEnumerable<Profession> GetAll() =>
            new SqlReaderContext().ProfessionsReadData();

        public IEnumerable<Profession> ToListByCreatedDateByDescending() =>
            new SqlReaderContext().ProfessionsReadData().OrderByDescending(p => p.CreatedDate);

        public IEnumerable<Profession> WhereFocus(Func<Profession, bool> predicate) =>
            new SqlReaderContext().ProfessionsReadData().Where(predicate);

    }
}
