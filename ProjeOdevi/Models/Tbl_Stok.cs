//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeOdevi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Stok
    {
        public int StokId { get; set; }
        public Nullable<int> UrunID { get; set; }
    
        public virtual Tbl_Urun Tbl_Urun { get; set; }
    }
}
