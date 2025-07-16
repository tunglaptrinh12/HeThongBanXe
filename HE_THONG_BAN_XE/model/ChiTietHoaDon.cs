using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{
    [Table("CSDL_ChiTietHoaDon")]
    internal class ChiTietHoaDon
    {
        [Key]
        [Required]
        [MaxLength(20)]
        public String? MaHD { get; set; }

        [Required]
        [MaxLength(50)]
        public String? MaKH { get; set; }

        [Required, StringLength(10)]
        public String? MaXe { get; set; }
        [Required, StringLength(50)]
        public String? MaKM { get; set; }
        [Required]
        public decimal? DonGia { get; set; }
        [Required]
        public DateTime NgayLayHD { get; set; }

        public Decimal ThanhTien { get; set; }

        // Khóa ngoại
        [ForeignKey("MaKH")]
        public virtual KhachHang? KhachHang { get; set; } // Mối quan hệ với bảng KhachHang, mỗi hóa đơn thuộc về một khách hàng

        [ForeignKey("MaXe")]
        public virtual Xe? Xe { get; set; } // Mối quan hệ với bảng Xe, mỗi hóa đơn liên quan đến một xe cụ thể
        [ForeignKey("MaKM")]
        public virtual KhuyenMai? KhuyenMais { get; set; } // Mối quan hệ với bảng khuyén mại, mỗi hóa đơn liên quan tới khuyến mại 
    }
}
