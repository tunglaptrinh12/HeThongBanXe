using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{
    [Table("CSDL_KhachHangDaKhuyenMai")]
    internal class KhachHangDaKhuyenMai
    {
        [Key]
        [Required,StringLength(50)]
        public String? MaKhuyenMai { get; set; }
        [Required, StringLength(50)]
        public String? MaKH { get; set; }
        [Required]
        public DateTime NgayApDung { get; set; }
        [Required]
        public Decimal GiaTriKhuyenMai { get; set; } // Phần trăm khuyến mãi
        [Required,StringLength(255)]
        public String? GhiChu { get; set; } // Mô tả về chương trình khuyến mãi

        // FK
        [ForeignKey("MaKH")]
        public virtual KhachHang ?KhachHang { get; set; } // Mối quan hệ với bảng KhachHang, mỗi khách hàng có thể có nhiều chương trình khuyến mãi đã áp dụng

    }
}
