using ADO.NET_Console_CRUD_application.Entities.Common;
using ADO.NET_Console_CRUD_application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Console_CRUD_application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);
        void Modify(int id,T entity);
        void Delete(int id);
    }
}
