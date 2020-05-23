using Microsoft.EntityFrameworkCore;
using PersonaProyec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaProyec.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\PersonaProyec.db");

        }
    }
}
