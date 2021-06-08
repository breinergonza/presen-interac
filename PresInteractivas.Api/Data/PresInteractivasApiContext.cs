using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PresInteractivas.Api.Models;

namespace PresInteractivas.Api.Data
{
    public class PresInteractivasApiContext : DbContext
    {
        public PresInteractivasApiContext (DbContextOptions<PresInteractivasApiContext> options)
            : base(options)
        {
        }

        public DbSet<PresInteractivas.Api.Models.UserDto> UserDto { get; set; }
    }
}
