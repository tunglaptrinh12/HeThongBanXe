using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.model
{
    [Table("CSDL_KhuyenMai")]
    internal class KhuyenMai
    {
        [Key]
        [Required]
        public string? MaKM { get; set; }
        [Required]
        public string? TenKM { get; set; }
        [Required]
        public string? LoaiKM { get; set; }
        [Required]
        public decimal GiaTriKM { get; set; }
        [Required]
        public string? DieuKien {  get; set; }
        [Required]
        public DateTime? NgayBatDau { get; set; }
        [Required]
        public DateTime? NgayKetThuc {  get; set; }
        [Required]
        public string? TrangThai {  get; set; }

    }
}
