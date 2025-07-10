using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanvetau.model
{
    internal class VeTau
    {
        [Key]
        public int MaVe { get; set; }
        

        public int? MaChuyen { get; set; }
        

        public int? MaHanhKhach { get; set; }
        [Required(ErrorMessage = "Ngày đặt không được để trống")]
        public DateTime NgayDat { get; set; }
        [Required(ErrorMessage = "Số ghế không được để trống")]

        public string SoGhe { get; set; }
        [Required(ErrorMessage = "Giá vé không được để trống")]
        [Precision(18,2)]
        public decimal GiaVe { get; set; }
        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public string TrangThai { get; set; }
        
        public int? MaNV { get; set; } // Mã nhân viên đã bán vé
        [ForeignKey("MaChuyen")]
        public virtual ChuyenTau? ChuyenTau { get; set; }
        [ForeignKey("MaHanhKhach")]
        public virtual HanhKhach? HanhKhach { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien? NhanVien { get; set; } // Nhân viên bán vé



    }
}
