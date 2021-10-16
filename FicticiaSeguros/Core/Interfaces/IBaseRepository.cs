using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicticiaSeguros.Core.Models;

namespace FicticiaSeguros.Core.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
   
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        
        Task Update(T entity);
        Task Delete(int id);
        bool EntityExists(int id);
    }
}
