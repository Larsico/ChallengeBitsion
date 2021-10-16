using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiaSeguros.Core.DTOs
{
    public class PersonsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Identification { get; set; }
        public int Age { get; set; }
        public bool State { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
