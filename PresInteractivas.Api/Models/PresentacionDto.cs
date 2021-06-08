using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresInteractivas.Api.Models
{
    public class PresentacionDto
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateCreation { get; set; }
        public int userCreates { get; set; }

    }
}
