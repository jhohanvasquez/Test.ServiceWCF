﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Service.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DotNetNukeEntities : DbContext
    {
        public DotNetNukeEntities()
            : base("name=DotNetNukeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<js_DNNJuliusForm> js_DNNJuliusForm { get; set; }
        public virtual DbSet<js_DNNJuliusFormArchivo> js_DNNJuliusFormArchivo { get; set; }
    }
}
