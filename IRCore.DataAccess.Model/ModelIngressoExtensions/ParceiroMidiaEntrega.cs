﻿//------------------------------------------------------------------------------
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

    public partial class ParceiroMidiaEntrega
    {
        public int ID { get; set; }
        public int EntregaID { get; set; }
        public int ParceiroMidiaID { get; set; }
        public char Ativo { get; set; }
        public string Texto { get; set; }
        public virtual ParceiroMidia ParceiroMidia { get; set; }
        public virtual tEntrega tEntrega { get; set; }
    }
}
