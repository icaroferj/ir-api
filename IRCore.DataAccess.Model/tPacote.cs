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
    
    public partial class tPacote
    {
        public tPacote()
        {
            this.tPacoteItem = new HashSet<tPacoteItem>();
            this.tVendaBilheteriaItem = new HashSet<tVendaBilheteriaItem>();
        }
    
        public int ID { get; set; }
        public Nullable<int> LocalID { get; set; }
        public string Nome { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public string Obs { get; set; }
        public string VendaDistribuida { get; set; }
        public string PermitirCancelamentoAvulso { get; set; }
        public Nullable<int> NomenclaturaPacoteID { get; set; }
    
        public virtual tLocal tLocal { get; set; }
        public virtual ICollection<tPacoteItem> tPacoteItem { get; set; }
        public virtual ICollection<tVendaBilheteriaItem> tVendaBilheteriaItem { get; set; }
    }
}