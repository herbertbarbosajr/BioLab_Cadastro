using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioLab_Cadastro.Models
{
    public class Conexao : DbContext
    {
      public Conexao (DbContextOptions<Conexao> options): base (options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
