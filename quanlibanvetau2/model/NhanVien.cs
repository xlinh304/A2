using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanvetau.model
{
    internal class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        public string TenNV { get; set; }
        [Required(ErrorMessage = "sodienthoai không được để trống")]
        public string SoDienThoai { get; set; }

        public virtual ICollection<TaiKhoan>? TaiKhoans { get; set; }
        public virtual ICollection<VeTau>? VeTaus { get; set; }
        public virtual ICollection<ThongKe>? ThongKes { get; set; }

    }
}
