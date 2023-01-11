using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Categorymodel
    {
        [Key]
        public int CategortId { get; set; }
        [Required]

        public string Name { get; set; }


        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Dispaly Order should be more than 1")]

        public int DisplayOrder { get; set; } 





    }
}
