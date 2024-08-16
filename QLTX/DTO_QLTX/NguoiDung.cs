namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        public int MaNguoiDung { get; set; }

        [StringLength(50)]
        public string TenNguoiDung { get; set; }

        [StringLength(40)]
        public string TaiKhoan { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string LoaiNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
