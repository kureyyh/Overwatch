using Overwatch.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IClientRepository Client { get; private set; }

        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Client = new ClientRepository(_db);
        }

        public void Save() 
        { 
        _db.SaveChanges();
        }
    }
}
