using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{   
    [Table("CSDL_Xe")]
    internal class Xe
    {
        [Key]
        [Required,StringLength(10)]
        public String? MaXe { get; set; }
        [Required, StringLength(100)]
        public String? TenXe { get; set; }
        [Required, StringLength(50)]
        public String? HangXe { get; set; }
        [Required, StringLength(50)]
        public String? LoaiXe { get; set; }
        [Required, StringLength(50)]
        public String? MauSac { get; set; }
        [Required]
        public int SoChoNgoi { get; set; }
        [Required]
        public DateTime NamSanXuat { get; set; }
        [Required, StringLength(20)]
        public String? BienSo { get; set; }
        [Required, StringLength(10)]
        public String? MoiCu { get; set; } 
        [Required]
        public Decimal GiaBan { get; set; }
        [Required, StringLength(20)]
        public String? TrangThai { get; set; }
        public virtual ICollection<ChiTietHoaDon>? ChiTietHoaDons { get; set; } // Mối quan hệ với bảng HoaDon, mỗi xe có thể có nhiều hóa đơn liên quan
    }
}
