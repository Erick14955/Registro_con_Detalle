﻿using Microsoft.EntityFrameworkCore;
using Registro_con_Detalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_con_Detalle.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/datosUsuarios.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisosId = 1, DescripcionPermisos = "Descuento"},
                new Permisos() { PermisosId = 2, DescripcionPermisos = "Vende"},
                new Permisos() { PermisosId = 3, DescripcionPermisos = "Compra"}
            );
        }
    }
}
