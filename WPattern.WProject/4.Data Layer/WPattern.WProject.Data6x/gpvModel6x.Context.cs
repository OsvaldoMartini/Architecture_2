﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPattern.WProject.Data6x
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gpvEntities6x : DbContext
    {
        public gpvEntities6x()
            : base("name=gpvEntities6x")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<claudiaTesteEntity> claudiaTesteEntities { get; set; }
        public virtual DbSet<martiniTesteEntity> martiniTesteEntities { get; set; }
        public virtual DbSet<tFatTarefaEntity> tFatTarefaEntities { get; set; }
        public virtual DbSet<tSegFuncionalidadeEntity> tSegFuncionalidadeEntities { get; set; }
        public virtual DbSet<tSegPerfilEntity> tSegPerfilEntities { get; set; }
        public virtual DbSet<tSegPerfilTelaFuncionalidadeEntity> tSegPerfilTelaFuncionalidadeEntities { get; set; }
        public virtual DbSet<tSegTelaEntity> tSegTelaEntities { get; set; }
        public virtual DbSet<tSegTelaFuncionalidadeEntity> tSegTelaFuncionalidadeEntities { get; set; }
        public virtual DbSet<tSegUsuarioEntity> tSegUsuarioEntities { get; set; }
    }
}
