using System.Threading.Tasks;
using FicticiaSeguros.Core.Interfaces;
using FicticiaSeguros.Core.Models;
using FicticiaSeguros.Data;
using FicticiaSeguros.Infrastructure.Repositories;

namespace FicticiaSeguros.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private readonly IBaseRepository<PersonModel> _personRepository;
        public IBaseRepository<PersonModel> PersonRepository => _personRepository ?? new BaseRepository<PersonModel>(_dbContext);

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
