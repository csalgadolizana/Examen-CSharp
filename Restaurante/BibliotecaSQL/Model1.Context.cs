﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaSQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestauranteEntities : DbContext
    {
        public RestauranteEntities()
            : base("name=RestauranteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cliente> cliente { get; set; }
        public DbSet<detalle_pedido> detalle_pedido { get; set; }
        public DbSet<menu> menu { get; set; }
        public DbSet<pedido> pedido { get; set; }
        public DbSet<usuario> usuario { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<venta> venta { get; set; }
    }
}
