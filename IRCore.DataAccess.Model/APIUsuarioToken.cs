//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRCore.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class APIUsuarioToken
    {
        public int ID { get; set; }
        public int APIUsuarioID { get; set; }
        public string Token { get; set; }
        public bool Ativo { get; set; }
        public string DadosIndentificacao { get; set; }
        public string DadosSession { get; set; }
        public System.DateTime DataExpiracao { get; set; }
        public virtual APIUsuario APIUsuario { get; set; }
        public int ClienteID { get; set; }
    }
}
