using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiaSeguros.Core.DTOs
{
    public class PersonCreateDTO
    {

        public string Name { get; set; }
        public int Identification { get; set; }
        public int Age { get; set; }
        public bool State { get; set; }
        public DateTime CretaedAt { get; set; }
        
        ///////OPTIONAL ATTRIBUTES /////////

        public bool IsDriver { get; set; }
        public bool UseLenses { get; set; }
        public bool IsDiabetic { get; set; } 
        public string OtherDisease { get; set; }



    }
}
