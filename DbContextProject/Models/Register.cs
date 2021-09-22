using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbContextProject.Models
{
    public class Register : DbContext
    {
        public DbSet<People> People { get; set; }
        public Register(DbContextOptions<Register> options)
         : base(options)
        { }
    }
}
