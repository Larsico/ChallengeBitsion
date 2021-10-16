using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicticiaSeguros.Core.DTOs;
using FicticiaSeguros.Core.Interfaces;
using FicticiaSeguros.Core.Interfaces.IServices;
using FicticiaSeguros.Core.Mapper;
using FicticiaSeguros.Core.Models;

namespace FicticiaSeguros.Core.Services
{
    public class PersonService : IPersonService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly EntityMapper _mapper = new EntityMapper();

        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PersonDetailsDTO> GetDetails(int id)
        {

            PersonModel pmodel = await _unitOfWork.PersonRepository.GetById(id);

            PersonDetailsDTO model = _mapper.FromPersonToPersonDetailsDTO(pmodel);

            return model;

        }

        public async Task<PersonModel> GetById(int id)
        {
            PersonModel pModel = await _unitOfWork.PersonRepository.GetById(id);

            return pModel;

        }


        public async Task<IEnumerable<PersonsDTO>> GetAll()
        {

            IEnumerable<PersonModel> model = await _unitOfWork.PersonRepository.GetAll();

            List<PersonsDTO> resultModel = model.OrderByDescending(o => o.CreatedAt).Select(m => _mapper.FromPersonToPersonDTO(m))
                .ToList();
            
           
            return resultModel;
        }

        public async Task<PersonUpdateDTO> PersonExists(int id)
        {
            PersonModel model = await _unitOfWork.PersonRepository.GetById(id);

            // de personModel a person model dto y devuelvo el dto


            PersonUpdateDTO pModel = _mapper.FromPersonModelToPersonUpdateDto(model);

            return pModel;
        }

        public async Task<bool> DeletePerson(int id)
        {
            try
            {
                await _unitOfWork.PersonRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public async Task<PersonModel> Update(PersonUpdateDTO model)
        {
            PersonModel pModel = _mapper.FromPersonUpdateDtoToPersonModel(model);

            await _unitOfWork.PersonRepository.Update(pModel);
            await _unitOfWork.SaveChangesAsync();

            return pModel;

        }


        public async Task<PersonModel> Create(PersonCreateDTO model)
        {

            PersonModel pModel = _mapper.FromPersonCreateDtoToPersonModel(model);

            await _unitOfWork.PersonRepository.Insert(pModel);
            await _unitOfWork.SaveChangesAsync();

            return pModel;
        }

        //public async Task<PersonModel> UpdateFullPersonModel(FullPersonGetDetailsDTO model)
        //{
        //    PersonModel pmodel = _mapper.FromFullPersonDTOToFullPersonModel(model);

        //    var result = _unitOfWork.PersonRepository.Update(pmodel);

        //    return pmodel;
        //}

        //public async Task<PersonWithOptAttributesPostDTO> Post(PersonWithOptAttributesPostDTO personWithOptionalAttributesDto)
        //{

        //    PersonModel pModel = new PersonModel();


        //    var mapper = new EntityMapper();
        //    pModel = mapper.FromPersonWithOptionalAttDtoToPersonModel(personWithOptionalAttributesDto);
        //    OptionalAttributesModel oModel =
        //        mapper.FromPersonWithOptionalAttDtoToOptionalAttributesModel(personWithOptionalAttributesDto);

        //    pModel.OptionalAttributes = oModel;

        //    await _unitOfWork.PersonRepository.Insert(pModel);
        //    await _unitOfWork.SaveChangesAsync();




        //    return personWithOptionalAttributesDto;
        //}


    }
}
