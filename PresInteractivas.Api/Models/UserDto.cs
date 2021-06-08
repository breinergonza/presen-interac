using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresInteractivas.Api.Models
{
    public class UserDto : LoginDto
    {
        [Key]
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int? idRedSocial { get; set; }
    }
}
