using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicticiaSeguros.Core.DTOs;
using FicticiaSeguros.Core.Models;

namespace FicticiaSeguros.Core.Mapper
{
    public class EntityMapper
    {
        public PersonsDTO FromPersonToPersonDTO(PersonModel pModel)
        {
            return new PersonsDTO
            {
                Id = pModel.Id,
                Name = pModel.Name,
                Age = pModel.Age,
                Identification = pModel.Identification,
                State = pModel.State,
                CreatedAt = pModel.CreatedAt
            };
        }

        public PersonDetailsDTO FromPersonToPersonDetailsDTO(PersonModel pModel)
        {
            return new PersonDetailsDTO
            {
                Id = pModel.Id,
                Name = pModel.Name,
                Age = pModel.Age,
                Identification = pModel.Identification,
                State = pModel.State,
                IsDiabetic = pModel.IsDiabetic,
                IsDriver = pModel.IsDriver,
                UseLenses = pModel.UseLenses,
                OtherDisease = pModel.OtherDisease,
                IsDeleted = pModel.IsDeleted,
                CreatedAt = pModel.CreatedAt
            };
        }

        public PersonModel FromPersonCreateDtoToPersonModel(PersonCreateDTO pModel)
        {
            return new PersonModel
            {
                Name = pModel.Name,
                Age = pModel.Age,
                Identification = pModel.Identification,
                State = pModel.State,
                IsDiabetic = pModel.IsDiabetic,
                IsDriver = pModel.IsDriver,
                UseLenses = pModel.UseLenses,
                OtherDisease = pModel.OtherDisease,
                CreatedAt = DateTime.Now
            };
        }

        public PersonModel FromPersonUpdateDtoToPersonModel(PersonUpdateDTO pModel)
        {
            return new PersonModel
            {
                Id = pModel.Id,
                Name = pModel.Name,
                Age = pModel.Age,
                Identification = pModel.Identification,
                State = pModel.State,
                IsDiabetic = pModel.IsDiabetic,
                IsDriver = pModel.IsDriver,
                UseLenses = pModel.UseLenses,
                OtherDisease = pModel.OtherDisease,
                CreatedAt = pModel.CreatedAt
                ///// obtener created at
            };
        }

        public PersonUpdateDTO FromPersonModelToPersonUpdateDto(PersonModel pModel)
        {

            return new PersonUpdateDTO
            {
                Id = pModel.Id,
                Name = pModel.Name,
                Age = pModel.Age,
                Identification = pModel.Identification,
                State = pModel.State,
                IsDiabetic = pModel.IsDiabetic,
                IsDriver = pModel.IsDriver,
                UseLenses = pModel.UseLenses,
                OtherDisease = pModel.OtherDisease,
                CreatedAt = pModel.CreatedAt
            };

        }

    }
}
