using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanvetau.model
{
    internal class ChuyenTau
    {
        [Key]
        public int MaChuyen { get; set; }
        [Required(ErrorMessage = "Tên tàu không được để trống")]
        public string TenTau { get; set; }
        [Required(ErrorMessage = "Ga đi không được để trống")]
        public string GaDi { get; set; }
        [Required(ErrorMessage = "Ga đến không được để trống")]
        public string GaDen { get; set; }
        [Required(ErrorMessage = "Thời gian khởi hành không được để trống")]
        public DateTime ThoiGianKhoiHanh { get; set; }
        [Required(ErrorMessage = "Thời gian đến không được để trống")]
        public DateTime ThoiGianDen { get; set; }
        [Required(ErrorMessage = "Số lượng ghế không được để trống")]
        public int TongSoGhe { get; set; }
        [Precision(18, 2)]
        public decimal GiaVe { get; set; }


        public virtual ICollection<VeTau>? VeTaus { get; set; }
        public virtual ICollection<ThongKe>? ThongKes { get; set; }

    }
}
