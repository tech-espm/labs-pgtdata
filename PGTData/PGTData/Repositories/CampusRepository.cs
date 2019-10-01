using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class CampusRepository : Repository<Campus>, ICampusRepository
    {
        public CampusRepository(DBPGTContext context) : base(context)
        {
        }
    }
}
