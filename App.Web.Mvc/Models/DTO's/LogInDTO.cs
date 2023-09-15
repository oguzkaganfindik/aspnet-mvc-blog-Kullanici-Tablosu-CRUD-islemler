using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Models.DTO_s
{
    public class LogInDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adı Zorunludur!!")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girmek zorundasınız")]
        [DisplayName("Kullanıcı Adı")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!!")]
        [DataType(DataType.Password)]
        [DisplayName("Şifre")]
        public string? Password { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
