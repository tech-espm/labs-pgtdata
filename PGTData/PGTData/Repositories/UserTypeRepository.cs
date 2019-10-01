using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class UserTypeRepository : Repository<UserType>, IUserTypeRepository
    {
        public UserTypeRepository(DBPGTContext context) : base(context)
        {

        }

    }
}
