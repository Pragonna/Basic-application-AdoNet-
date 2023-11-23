using ADO.NET_Console_CRUD_application.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Console_CRUD_application.Repositories.Interfaces
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> WhereFocus( Func<T, bool> predicate);
        T FirstOrDefaultFocus(Func<T, bool> predicate);
        T FindById(int id);
        IEnumerable<T> ToListByCreatedDateByDescending();

    }
}
