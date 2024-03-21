using System.ComponentModel.DataAnnotations;

namespace SinavHazirlik.Models
{
    public class UsersModel
    {
        [Required(ErrorMessage = "Lütfen Bir Kullanıcı Adı Giriniz.")]
        [StringLength(50, ErrorMessage = "50 karakterden fazla girilmez.")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "İsim ve Soyİsim alanı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Lütfen Sayısal İfade Kullanmayınız.")]
        public string IsimSoyisim { get; set; }

        [Required(ErrorMessage = "Eposta adresi boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçerli eposta adresi giriniz.")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        public string Parola { get; set; }

        [Compare("Parola",ErrorMessage = "Şifreler aynı değil.")]
        [Required(ErrorMessage = "Şifreler uyuşmuyo.")]
        public string Parolatekrar { get; set; }

        [Required(ErrorMessage = "Url Alanı boş bırakılamaz.")]
        [Url(ErrorMessage = "Url Yanlış")]
        public string Url { get; set; }

        [Range(1900,2010, ErrorMessage = "Doğum Yılını Bu Aralıklarda Giriniz")]
        [Required(ErrorMessage = "Lütfen Bir Doğum Yılı Giriniz.")]
        public int DogumYili { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Doğru Giriniz")]
        public string KullaniciAdiuyari { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Doğru Giriniz")]

        public string Parolauyari { get; set; }



    }
}
