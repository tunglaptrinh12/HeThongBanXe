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
        public String? MaCTHD { get; set; }
        [Required]
        [MaxLength(50)]
        public String? MaHD { get; set; }

        [Required]
        [MaxLength(50)]
        public String? MaKH { get; set; }

        [Required, StringLength(10)]
        public String? MaXe { get; set; }
        [Required, StringLength(50)]
        public String? MaKM { get; set; }
        [Required]
        public decimal DonGia { get; set; }
        public decimal GiaTriKhuyenMai { get; set; }
        [Required]
        public DateTime NgayLayHD { get; set; }

        public decimal ThanhTien { get; set; }

        [ForeignKey("MaHD")]
        public virtual HoaDon? HoaDon { get; set; }

        [ForeignKey("MaKH")]
        public virtual KhachHang? KhachHang { get; set; }

        [ForeignKey("MaXe")]
        public virtual Xe? Xe { get; set; }

        [ForeignKey("MaKM")]
        public virtual KhuyenMai? KhuyenMai { get; set; }
    }
}
