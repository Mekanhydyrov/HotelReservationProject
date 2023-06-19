using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlıgı 100 karakterden fazla olmaz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklama giriniz.")]
        [StringLength(500, ErrorMessage = "Hizmet açıklama 500 karakterden fazla olmaz.")]
        public string Description { get; set; }
    }
}
