using HE_THONG_BAN_XE.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.Connect
{
    internal class DBNhanVien : DbContext
    {
        public DbSet<NhanVien> nhanViens {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CSDL_DoAn1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
