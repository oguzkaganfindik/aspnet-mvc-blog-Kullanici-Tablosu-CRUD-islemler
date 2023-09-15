using App.Web.Mvc.Models.Entities.Concrete;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Models.DTO_s
{
    public class UserUpdateDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adı Zorunludur!!")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girmek zorundasınız")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-Mail Zorunludur!!")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!!")]
        [DataType(DataType.Password)]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        public UserUpdateDTO()
        {

        }

        public UserUpdateDTO(AppUser user)
        {
            UserName = user.UserName;
            Password = user.PasswordHash;
            Email = user.Email;
        }
    }
}
