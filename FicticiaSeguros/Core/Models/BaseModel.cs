using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FicticiaSeguros.Core.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
