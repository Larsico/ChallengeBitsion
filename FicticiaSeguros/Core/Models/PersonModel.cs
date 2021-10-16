using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiaSeguros.Core.Models
{
    public class PersonModel : BaseModel
    {
        [Required(ErrorMessage = "El Nombre no puede estar vacio")]
        public string Name { get; set; }
        [Required]
        [Range(1000000, 100000000, ErrorMessage = "The Identification number must be between 1 million and 100 million")]
        public int Identification { get; set; }
        [Required]
        [Range(1, 120, ErrorMessage = "Age value must be between 1 and 120 years")]
        public int Age { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool State { get; set; }

        ///////OPTIONAL ATTRIBUTES /////////

        public bool IsDriver { get; set; }
        public bool UseLenses { get; set; }
        public bool IsDiabetic { get; set; }
        public string OtherDisease { get; set; }
    }
}
