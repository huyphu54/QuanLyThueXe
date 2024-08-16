namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HopDongs = new HashSet<HopDong>();
        }

        public KhachHang (int maKhachHang, string tenKhachHang, double? soCCCD, int? soDienThoai)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            this.soCCCD = soCCCD;
            SoDienThoai = soDienThoai;
        }

        [Key]
        public int MaKhachHang { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        public double? soCCCD { get; set; }

        public int? SoDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
