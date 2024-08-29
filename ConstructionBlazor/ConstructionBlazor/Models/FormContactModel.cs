using System.ComponentModel.DataAnnotations;

namespace ConstructionBlazor.Models
{
    public class FormContactModel
    {
        [Required(ErrorMessage = "Tên bị trống")]
        public string Name { get; set; } 
        [Required(ErrorMessage = "Email bị trống")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [Required(ErrorMessage = "Số điện thoại bị trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Thông tin chi tiết bị trống")]
        public string Description {  get; set; } 
    }
}
