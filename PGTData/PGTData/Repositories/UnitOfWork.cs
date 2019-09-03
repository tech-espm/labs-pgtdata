using PGTData.Context;
using PGTData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBPGTContext _context;

        public UnitOfWork(DBPGTContext context)
        {
            _context = context;

            User = new UserRepository(_context);
        }

        public IUserRepository User { get; private set; }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}

