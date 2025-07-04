using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{
    [Table("CSDL_NhanVien")]
    internal class NhanVien
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public String? MaNV { get; set; }
        [Required]
        [MaxLength(100)]
        public String? TenNV { get; set; }
        [MaxLength(10)]
        public String? GioiTinh { get; set; }
        public DateTime? NamSinh { get; set; }
        [Required]
        public String? SDT { get; set; }
        [Required]
        [MaxLength(100)]
        public String? Email { get; set; }
        public String? ChucVu { get; set; }

    }
}
