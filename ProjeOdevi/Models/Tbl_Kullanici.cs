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
    using System.ComponentModel.DataAnnotations;

    public partial class Tbl_Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Kullanici()
        {
            this.Tbl_Zimmet = new HashSet<Tbl_Zimmet>();
        }
        [Required]
        public int KullaniciId { get; set; }
        [Required]
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        [Display(Name = "Personel Ad�")]
        [Required(ErrorMessage = "Kullan�c� Ad�n�z� giriniz.")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "�ifre")]
        [Required(ErrorMessage = "�ifrenizi giriniz.")]
        public string Sifre { get; set; }
        public Nullable<int> RolID { get; set; }
        public Nullable<int> BolumID { get; set; }
        public Nullable<bool> Durum { get; set; }

        public virtual Tbl_Bolum Tbl_Bolum { get; set; }
        public virtual Tbl_Rol Tbl_Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Zimmet> Tbl_Zimmet { get; set; }
    }
}
