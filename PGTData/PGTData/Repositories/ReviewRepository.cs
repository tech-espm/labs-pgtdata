using Microsoft.EntityFrameworkCore;
using PGTData.Common;
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

        public List<Review> GetHistoric(string StartDate, string EndDate)
        {
            DateString dateString = new DateString();

            var startDate = dateString.ToDateTime(StartDate);
            var endDate = dateString.ToDateTime(EndDate);

            var queryfilter = _entities
                .Where(x => x.ReviewDate >= startDate && x.ReviewDate <= endDate)
                .AsNoTracking();

            return queryfilter.ToList();
        }
    }
}
