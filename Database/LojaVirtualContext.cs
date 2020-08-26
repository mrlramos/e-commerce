using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// EF Core - Entity Framework core : ORM - Object-Relational Mapping

namespace LojaVirtual.Database
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base (options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
