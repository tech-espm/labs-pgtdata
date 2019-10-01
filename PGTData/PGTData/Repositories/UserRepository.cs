﻿using Microsoft.EntityFrameworkCore;
using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System.Collections.Generic;

namespace PGTData.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBPGTContext context) : base(context)
        {
        }
    }
}
