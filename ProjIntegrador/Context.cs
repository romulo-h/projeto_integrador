using Microsoft.EntityFrameworkCore;
using ProjIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }
        //Declara as tabelas do banco
        public DbSet<Doador> Doador { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<LogDoacao> LogDoacao { get; set; }
        public DbSet<Doacoes> Doacoes { get; set; }
    }
}
