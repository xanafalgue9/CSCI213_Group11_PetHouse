using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHouse.Models;

namespace PetHouse.Data
{
    public class PetHouseContext : DbContext
    {
        public PetHouseContext (DbContextOptions<PetHouseContext> options)
            : base(options)
        {
        }

        public DbSet<PetHouse.Models.User> User { get; set; } = default!;
    }
}
