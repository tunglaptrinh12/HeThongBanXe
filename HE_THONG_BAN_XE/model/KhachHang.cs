using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{
    [Table("CSDL_KhachHang")]
    internal class KhachHang
    {
        [Key]
        [Required]
        [MaxLength(50)] 
        public String? MaKH { get; set; }
        [Required]
        [MaxLength(100)]
        public String? TenKH { get; set ; }
        [MaxLength(10)]
        public String? GioiTinh { get; set ; }
        public DateTime? NgaySinh { get; set ; }
        [StringLength(10)]
        [RegularExpression(@"^[0-9]{10}$")]
        public string? SDT { get; set ; }
        [StringLength(100)]
        [EmailAddress]
        public String? Email { get; set ; }
        [MaxLength(255)]
        public String? DiaChi { get; set ; }
        // Quan hệ
        public virtual ICollection<HoaDon> ?HoaDons { get; set; } // Mối quan hệ với bảng HoaDon, mỗi khách hàng có thể có nhiều hóa đơn liên quan
        public virtual ICollection<KhachHangDaKhuyenMai> ?DanhSachKhuyenMai { get; set; } // Mối quan hệ với bảng KhachHangDaKhuyenMai, mỗi khách hàng có thể có nhiều chương trình khuyến mãi đã áp dụng
    }
}
