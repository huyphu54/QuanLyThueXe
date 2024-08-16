namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDong()
        {
            ChiTietHopDongs = new HashSet<ChiTietHopDong>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int MaHopDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLaphopDong { get; set; }

        public double? TongTien { get; set; }

        public double? TienDatCoc { get; set; }

        [StringLength(100)]
        public string CacDieuKhoan { get; set; }

        public int? MaNguoiDung { get; set; }

        public int? MaKhachHang { get; set; }

        public bool ThanhToan {  get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHopDong> ChiTietHopDongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
