using Overwatch.DataAccess.Repository.IRepository;
using Overwatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.DataAccess.Repository
{
    public class OrganisationRepository : Repository<Organisation>, IOrganisationRepository
    {
        private ApplicationDbContext _db;

        public OrganisationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Organisation obj)
        {
            _db.Organisations.Update(obj);


            //var objFromDb = _db.Organisations.FirstOrDefault(u => u.Id == obj.Id);
            //if (objFromDb != null) 
            //{ 
            //        objFromDb.EnNog wat  = fn
            //}
        }
    }
}
