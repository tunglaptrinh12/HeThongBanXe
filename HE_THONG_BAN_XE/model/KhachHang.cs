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
        public string? SDT { get; set ; }
        [MaxLength(100)]
        public String? Email { get; set ; }
        [MaxLength(255)]
        public String? DiaChi { get; set ; }
    }
}
