using PGTData.Context;
using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories.Interfaces
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(DBPGTContext context) : base(context)
        {

        }
    }
}
