using ClosedXML.Excel;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using HE_THONG_BAN_XE.Connect;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace HE_THONG_BAN_XE.ControlHeThong
{
    public partial class BaoCaoControl : UserControl
    {
        public BaoCaoControl()
        {
            InitializeComponent();

        }

        private void BaoCaoControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            DateTime ngayChon = dtNgay.Value.Date;

            using (var db = new DBNhanVien())
            {
                // ✅ DOANH THU TRONG NGÀY
                var doanhThu = db.hoaDons
                    .Where(hd => hd.NgaylapHD.HasValue && hd.NgaylapHD.Value.Date == ngayChon)
                    .Sum(hd => (decimal?)hd.ThanhTien) ?? 0;
                lblDoanhThu.Text = doanhThu.ToString("N0") + " VNĐ";

                // ✅ TỔNG XE ĐÃ BÁN TRONG NGÀY (theo chi tiết hóa đơn)
                var xeBan = (from ct in db.chiTietHoaDons
                             join hd in db.hoaDons on ct.MaHD equals hd.MaHD
                             where hd.NgaylapHD.HasValue && hd.NgaylapHD.Value.Date == ngayChon
                             select ct).Count();
                lblXeBan.Text = xeBan.ToString();

                // ✅ TỔNG KHÁCH HÀNG
                lblKhachHang.Text = db.khachHangs.Count().ToString();

                // ✅ TỒN KHO (Tổng số lượng xe còn lại)
                var tonKho = db.xes.Sum(x => (int?)x.SoChoNgoi) ?? 0;
                lblTonKho.Text = tonKho.ToString();

                // ✅ TỔNG NHÂN VIÊN
                lblNhanVien.Text = db.nhanViens.Count().ToString();

                // ✅ DỮ LIỆU XE ĐÃ BÁN TRONG NGÀY (dgvXeBan)
                var danhSachXeBan = from ct in db.chiTietHoaDons
                                    join hd in db.hoaDons on ct.MaHD equals hd.MaHD
                                    join xe in db.xes on ct.MaXe equals xe.MaXe
                                    join kh in db.khachHangs on ct.MaKH equals kh.MaKH
                                    where hd.NgaylapHD.HasValue && hd.NgaylapHD.Value.Date == ngayChon
                                    select new
                                    {
                                        ct.MaCTHD,
                                        hd.MaHD,
                                        TenKhachHang = kh.TenKH,
                                        TenXe = xe.TenXe,
                                        ct.DonGia,
                                        ct.ThanhTien,
                                        NgayLap = hd.NgaylapHD.Value
                                    };

                dgvXeBan.DataSource = danhSachXeBan.ToList();
            }

        }

       

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            string filePath = "BaoCao_" + dtNgay.Value.ToString("yyyyMMdd_HHmmss") + ".pdf";

            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document doc = new Document(pdf);

                    // Title
                    Paragraph title = new Paragraph("BÁO CÁO BÁN HÀNG")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20);

                    doc.Add(title);

                    doc.Add(new Paragraph("\n"));

                    // Ngày tạo báo cáo
                    string selectedDate = dtNgay.Value.ToString("dd/MM/yyyy");
                    doc.Add(new Paragraph("Ngày: " + selectedDate));

                    // Doanh thu
                    doc.Add(new Paragraph("Doanh thu trong ngày: " + lblDoanhThu.Text));
                    doc.Add(new Paragraph("Tổng số xe bán được: " + lblXeBan.Text));
                    doc.Add(new Paragraph("Tổng khách hàng: " + lblKhachHang.Text));
                    doc.Add(new Paragraph("Sản lượng tồn kho: " + lblTonKho.Text));
                    doc.Add(new Paragraph("Tổng nhân viên: " + lblNhanVien.Text));

                    doc.Add(new Paragraph("\nDanh sách xe đã bán trong ngày:\n"));

                    // Bảng từ DataGridView
                    iText.Layout.Element.Table table = new iText.Layout.Element.Table(dgvXeBan.Columns.Count);

                    // Thêm header
                    foreach (DataGridViewColumn col in dgvXeBan.Columns)
                    {
                        table.AddHeaderCell(new iText.Layout.Element.Cell().Add(new Paragraph(col.HeaderText)));
                    }

                    // Thêm dữ liệu
                    foreach (DataGridViewRow row in dgvXeBan.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new iText.Layout.Element.Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                            }
                        }
                    }

                    doc.Add(table);

                    doc.Close();
                }
            }

            MessageBox.Show("Xuất báo cáo thành công!\nFile lưu tại: " + Path.GetFullPath(filePath),
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}

