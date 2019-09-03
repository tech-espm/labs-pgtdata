using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IAttachmentTypeRepository AttachmentType { get; } 

        Task<int> Complete();
    }
}
