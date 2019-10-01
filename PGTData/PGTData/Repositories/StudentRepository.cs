using Microsoft.EntityFrameworkCore;
using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DBPGTContext context) : base(context)
        {

        }

        public List<Student> GetByGroup (int GroupID)
        {
            var queryfilter = _entities.Include(x => x.Group)
                .Where(x => x.GroupID == GroupID)
                .AsNoTracking();

            return queryfilter.ToList();
        }
    }
}
