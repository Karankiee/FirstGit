using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class MemberModel
    {
        [Required(ErrorMessage = "กรอกชื่อ")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "กรอกที่อยู่")]
        public string Address { get; set; }
    }
}
