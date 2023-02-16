using Overwatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.DataAccess.Repository.IRepository
{
    public interface IOrganisationRepository : IRepository<Organisation>
    {
        void Update(Organisation obj);
    }
}
