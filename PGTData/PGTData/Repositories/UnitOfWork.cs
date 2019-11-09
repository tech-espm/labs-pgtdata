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
            UserType = new UserTypeRepository(_context);
            Campus = new CampusRepository(_context);
            City = new CityRepository(_context);
            Group = new GroupRepository(_context);
            State = new StateRepository(_context);
            Student = new StudentRepository(_context);
            Review = new ReviewRepository(_context);
            File = new FileRepository(_context);
            Comment = new CommentRepository(_context);
            Warning = new WarningRepository(_context);

        }

        public IUserRepository User { get; private set; }
        public IUserTypeRepository UserType { get; private set; }
        public ICampusRepository Campus { get; private set; }
        public ICityRepository City { get; private set; }
        public IGroupRepository Group { get; private set; }
        public IStateRepository State { get; private set; }
        public IStudentRepository Student { get; private set; }
        public IReviewRepository Review { get; private set; }
        public IFileRepository File { get; private set; }
        public ICommentRepository Comment { get; private set; }
        public IWarningRepository Warning { get; private set; }

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

