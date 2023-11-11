using ADO.NET_Console_CRUD_application.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Console_CRUD_application.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
    }
}
