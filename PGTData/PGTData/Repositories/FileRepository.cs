using PGTData.Context;
using PGTData.Models;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class FileRepository : Repository<File>, IFileRepository
    {
        public FileRepository(DBPGTContext context) : base(context)
        {

        }
    }
}
