using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanvetau.model
{
    internal class TaiKhoan
    {
        [Key]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string MatKhau { get; set; }
        [Required(ErrorMessage = "Vai trò không được để trống")]
        public string VaiTro { get; set; }


        public int? MaNV { get; set; }
        

        public int? MaHanhKhach { get; set; }

        [ForeignKey("MaNV")]
        public NhanVien? NhanVien { get; set; }

        [ForeignKey("MaHanhKhach")]
        public HanhKhach? HanhKhach { get; set; }

    }
}
