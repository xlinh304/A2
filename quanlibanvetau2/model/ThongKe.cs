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
    internal class ThongKe
    {
        [Key]
        public int MaThongKe { get; set; }
        [Required(ErrorMessage = "Ngày không được để trống")]
        public DateTime Ngay { get; set; }
        
        public int? MaChuyen { get; set; }
       
        public int? MaNV { get; set; }
       
        public int TongVeDaBan { get; set; } 
        [Required(ErrorMessage = "Doanh thu không được để trống")]
        [Precision(18,2)]
        public decimal DoanhThu { get; set; } 
        
        

        [ForeignKey("MaChuyen")]
        public ChuyenTau? ChuyenTau { get; set; }

        [ForeignKey("MaNV")]
        public NhanVien? NhanVien { get; set; }

    }
}
