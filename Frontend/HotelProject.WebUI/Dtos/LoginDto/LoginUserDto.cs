using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adı Gereklidir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre Gereklidir.")]
        public string Password { get; set; }
    }
}
