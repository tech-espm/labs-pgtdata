using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(DBPGTContext context) : base(context)
        {

        }
    }
}
