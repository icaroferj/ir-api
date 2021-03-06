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
    
    public partial class tCaixa
    {
        public tCaixa()
        {
            this.tVendaBilheteria = new HashSet<tVendaBilheteria>();
        }
    
        public int ID { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public Nullable<int> LojaID { get; set; }
        public Nullable<int> ApresentacaoID { get; set; }
        public Nullable<decimal> SaldoInicial { get; set; }
        public string DataAbertura { get; set; }
        public string DataFechamento { get; set; }
        public Nullable<int> Comissao { get; set; }
        public Nullable<bool> GerouConciliacao { get; set; }
        public Nullable<int> ConciliacaoID { get; set; }
    
        public virtual tUsuario tUsuario { get; set; }
        public virtual ICollection<tVendaBilheteria> tVendaBilheteria { get; set; }
        public virtual tLoja tLoja { get; set; }
    }
}
