using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IClientRepository Client { get; }

        void Save();
    }
}
