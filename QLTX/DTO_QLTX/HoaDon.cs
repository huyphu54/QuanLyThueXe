namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        public double? TongTien { get; set; }
        public int? MaHopDong { get; set; }
        public double? PhatSinh { get; set; }
        public DateTime NgayLaphopDong { get; set; }

        public virtual HopDong HopDong { get; set; }
    }
}
    