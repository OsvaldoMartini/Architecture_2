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
    
    public partial class tSegTelaEntity
    {
        public tSegTelaEntity()
        {
            this.tSegTelaFuncionalidades = new HashSet<tSegTelaFuncionalidadeEntity>();
        }
    
        public int UID_TELA { get; set; }
        public string TEL_DES_CHAVE { get; set; }
        public string TEL_DES { get; set; }
        public string TEL_DES_URL { get; set; }
    
        public virtual ICollection<tSegTelaFuncionalidadeEntity> tSegTelaFuncionalidades { get; set; }
    }
}