﻿using CriadoresCaes.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CriadoresCaes.Data {

    /// <summary>
    /// esta classe representa a BD do projeto
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext {

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        /*
         * criação das tabelas da base de dados
         */

        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Animais> Animais { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }



    }
}