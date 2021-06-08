using Microsoft.EntityFrameworkCore;
using PresInteractivas.Api.Data;
using PresInteractivas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresInteractivas.Api.BL
{
    public class RegisterBL
    {
        //private readonly PresInteractivasApiContext _context;

        //public RegisterBL(PresInteractivasApiContext context)
        //{
        //    _context = context;
        //}

        /// <summary>
        /// Metodo que devuelve el listado de usuarios
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            // Pendiente por implementar
            //return await _context.UserDto.ToListAsync();

            return await usersMokup();
        }

        /// <summary>
        /// Metodo para consultar un usuario por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserDto> GetUser(int id)
        {
            // Pendiente por implementar
            //var userDto = await _context.UserDto.FindAsync(id);
            List<UserDto> users = await usersMokup();

            var userDto = users.FirstOrDefault(x => x.id == id);

            if (userDto == null)
            {
                throw new ArgumentException("El usuario que intenta consultar no existe!");
            }

            return userDto;
        }

        /// <summary>
        /// Metodo para agregar un usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<UserDto> AddUser(UserDto user)
        {
            // Pendiente por implementar
            //_context.UserDto.Add(userDto);
            //await _context.SaveChangesAsync();

            _usersMokup.Add(item: user);

            return user;
        }

        //public async Task<IActionResult> PutUser(int id, UserDto userDto)
        //{
        //    if (id != userDto.id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(userDto).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserDtoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}


        //private bool UserDtoExists(int id)
        //{
        //    return _context.UserDto.Any(e => e.id == id);
        //}

        /// <summary>
        ///  Mokup de BD
        /// </summary>
        /// <returns></returns>
        private async Task<List<UserDto>> usersMokup()
        {
            var usersMokup = _usersMokup;                       
            return usersMokup;
        }

        private List<UserDto> _usersMokup = new List<UserDto>()
            {
                new UserDto()
                {
                    id = 1,
                    nombres = "Breitner Enrique",
                    apellidos = "Gonzalez Angarita",
                    fechaNacimiento = new DateTime(day: 14, month: 12, year: 1986),
                    idRedSocial = 1, //Google
                    user = "breinergonza@hotmail.com",
                    password = "admin123"
                },
                new UserDto()
                {
                    id = 2,
                    nombres = "Alejandro",
                    apellidos = "Gonzalez",
                    fechaNacimiento = new DateTime(day: 10, month: 12, year: 2018),
                    idRedSocial = 1, //Google
                    user = "alejandro2018@hotmail.com",
                    password = "admin123"
                }
            };
    }
}
