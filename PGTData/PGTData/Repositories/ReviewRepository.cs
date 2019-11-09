﻿using Microsoft.EntityFrameworkCore;
using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(DBPGTContext context) : base(context)
        {

        }

        public List<Review> GetByUser(int UserID)
        {
            var queryfilter = _entities.Include(x => x.User)
                .Where(x => x.UserID == UserID)
                .AsNoTracking();

            return queryfilter.ToList();
        }
    }
}
