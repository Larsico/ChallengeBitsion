using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicticiaSeguros.Core.Models;

namespace FicticiaSeguros.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<PersonModel> PersonRepository { get; }

        Task SaveChangesAsync();
    }
}
