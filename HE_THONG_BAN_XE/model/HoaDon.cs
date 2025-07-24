using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{
    [Table("CSDL_HoaDon")]
    internal class HoaDon
    {
        [Key]
        [Required]
        public String? MaHD {  get; set; }
        [Required]
        
        public String? MaKH { get; set; }
        [Required]
        public int? SoLuong { get; set; }
        [Required]
        public DateTime? NgaylapHD { get; set; }
        [Required]
        public decimal ThanhTien { get; set; }

        [ForeignKey("MaKH")]
        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<ChiTietHoaDon>? ChiTietHoaDons { get; set; }

    }
}
