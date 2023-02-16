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
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Client = new ClientRepository(_db);
            Organisation = new OrganisationRepository(_db); 
        }

        public IClientRepository Client { get; private set; }

        public IOrganisationRepository Organisation { get; private set; }


        public void Save() 
        { 
        _db.SaveChanges();
        }
    }
}
