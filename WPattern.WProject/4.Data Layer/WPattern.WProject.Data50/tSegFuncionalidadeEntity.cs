//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPattern.WProject.Data50
{
    using System;
    using System.Collections.Generic;
    
    public partial class tSegFuncionalidadeEntity
    {
        public tSegFuncionalidadeEntity()
        {
            this.tSegTelaFuncionalidades = new HashSet<tSegTelaFuncionalidadeEntity>();
        }
    
        public int UID_FUNCIONALIDADE { get; set; }
        public string FUN_CHAVE { get; set; }
        public string FUN_DES { get; set; }
    
        public virtual ICollection<tSegTelaFuncionalidadeEntity> tSegTelaFuncionalidades { get; set; }
    }
}