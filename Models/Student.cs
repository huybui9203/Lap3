using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ và tên tối thiểu 4 ký tự, tối đa 100 ký tự")]
        [Required(ErrorMessage = "Họ và tên bắt buộc phải được nhập")]
        [DisplayName("Họ và tên")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$",
            ErrorMessage = "Địa chỉ email phải có đuôi @gmail.com")]
        [DisplayName("Email")]

        public string? Email { get; set; } //Email
        [StringLength(100, MinimumLength = 8, ErrorMessage ="Mật khẩu phải có 8 ký tự trở lên")]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$",
            ErrorMessage = "Mật khẩu phải có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        [DisplayName("Mật khẩu")]

        public string? Password { get; set; }//Mật khẩu
        [Required(ErrorMessage = "Ngành học bắt buộc phải được nhập")]
        [DisplayName("Ngành học")]

        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Giới tính bắt buộc phải được chọn")]
        [DisplayName("Giới tính")]

        public Gender? Gender { get; set; }//Giới tính
        [DisplayName("Hệ")]

        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        [DisplayName("Địa chỉ")]

        public string? Address { get; set; }//Địa chỉ
        [Required(ErrorMessage = "Ngày sinh không hợp lệ")] 
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 1/1/1963 đến 12/31/2005")]
        [DataType(DataType.Date)]

        [DisplayName("Ngày sinh")]

        public DateTime? DateOfBirth { get; set; }//Ngày sinh

        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        [DisplayName("Điểm")]
        public double? Diem { get; set; } //Điểm



    }
}
