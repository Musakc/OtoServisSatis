using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Kullanici : IEntitiy
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Display(Name = "Adı"),Required(ErrorMessage ="{0} Boş Bırakılamaz!")]

        public string Adi { get; set; }
        [StringLength(50), Display(Name = "Soyadı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]

        public string Soyadi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]

        public string Email { get; set; }
        [StringLength(20)]

        public string? Telefon { get; set; }
        [StringLength(50)]
        //[Display(Name = "Kullanıcı Adı")]

        public string? KullaniciAdi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        //[Display(Name = "Şifre")]

        public string Sifre { get; set; }

        public bool AktifMi { get; set; }
        [Display(Name ="Eklenme Tarihi"), ScaffoldColumn(false)] 

        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
                                             //             └► el ile girilmesin diye yazdık
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }
        [Display(Name = "Kullanıcı Rolü")]

        public virtual Rol? Rol{ get; set; } 
    }
}
