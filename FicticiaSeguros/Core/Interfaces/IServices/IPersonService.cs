using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicticiaSeguros.Core.DTOs;
using FicticiaSeguros.Core.Models;
using FicticiaSeguros.Core.Models;

namespace FicticiaSeguros.Core.Interfaces.IServices
{
    public interface IPersonService
    {

        public Task<PersonUpdateDTO> PersonExists(int id);

        public Task<bool> DeletePerson(int id);

        public Task<PersonModel> Create(PersonCreateDTO model);

        public Task<IEnumerable<PersonsDTO>> GetAll();
        public Task<PersonModel> GetById(int id);
        public Task<PersonDetailsDTO> GetDetails(int id);
        public Task<PersonModel> Update(PersonUpdateDTO model);


    }
}
