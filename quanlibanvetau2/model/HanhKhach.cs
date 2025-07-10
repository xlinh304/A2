using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanvetau.model
{
    internal class HanhKhach
    {
        [Key]
        public int MaHanhKhach { get; set; }
        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "CMND không được để trống")]
        public int CMND { get; set; }
        [Required(ErrorMessage = "Dien thoai không được để trống")]
        public string DienThoai { get; set; }
        [Required(ErrorMessage = "DiaChi không được để trống")]

        public string DiaChi { get; set; }


        public virtual ICollection<TaiKhoan>? TaiKhoans { get; set; }
        public virtual ICollection<VeTau>? VeTaus { get; set; }
        


    }
}
