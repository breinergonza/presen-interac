using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresInteractivas.Api.BL;
using PresInteractivas.Api.Data;
using PresInteractivas.Api.Models;

namespace PresInteractivas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private RegisterBL _reg = new RegisterBL();

        public UsersController()
        {
        }

        /// <summary>
        /// Metodo que devuelve el listado general de usuarios de la solución
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUserDto()
        {
            return  Ok(await _reg.GetUsers());
        }

        /// <summary>
        /// Metodo para consultar un usuario
        /// </summary>
        /// <param name="id">Id del usuario a consultar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var resp = await _reg.GetUser(id);

            if (resp != null)
            {
                return Ok(resp);
            }
            else
            {
                return BadRequest(resp);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<UserDto>> AddUser(UserDto user)
        {
            UserDto resp = await _reg.AddUser(user);

            return Ok(resp);
        }

        ///// <summary>
        ///// Metodo para actualizar un usuario
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="userDto"></param>
        ///// <returns></returns>
        //[HttpPut("{id}")]
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


        ///// <summary>
        ///// Metodo para eliminar un usuario
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUserDto(int id)
        //{
        //    var userDto = await _context.UserDto.FindAsync(id);
        //    if (userDto == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.UserDto.Remove(userDto);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        
    }
}
