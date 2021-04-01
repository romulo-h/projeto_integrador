﻿using Microsoft.EntityFrameworkCore;
using ProjIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public Contexto()
        {
            Database.EnsureCreated();
        }
        //Declara as tabelas do banco
        public DbSet<Doador> Doador { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<LogDoacao> LogDoacao { get; set; }
    }
}
