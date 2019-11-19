using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        List<Review> GetByUser(int UserID);
        List<Review> GetHistoric(string StartDate, string EndDate);
    }
}
