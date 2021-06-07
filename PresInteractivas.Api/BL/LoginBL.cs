using PresInteractivas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresInteractivas.Api.BL
{
    public class LoginBL
    {
        /// <summary>
        /// Metodo para validar la autenticación 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Auth(LoginDto data)
        {
            var resp = data.user == "breinergonza@hotmail.com" && data.password == "admin123";
            return resp;
        }
    }
}
