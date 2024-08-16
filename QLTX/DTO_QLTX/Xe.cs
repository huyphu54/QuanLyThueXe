namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            ChiTietHopDongs = new HashSet<ChiTietHopDong>();
            SoXeRas = new HashSet<SoXeRa>();
            SoXeVaos = new HashSet<SoXeVao>();
            SuaChuas = new HashSet<SuaChua>();
        }

        [Key]
        public int MaXe { get; set; }

        [StringLength(10)]
        public string BienSo { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }

        [StringLength(100)]
        public string TinhTrang { get; set; }

        public double? GiaThue { get; set; }

        public int? MaLoaiXe { get; set; }

        public int? MaThuongHieu { get; set; }

        public bool? MayLanh { get; set; }

        public bool? AC { get; set; }

        public bool? CamBienLui { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHopDong> ChiTietHopDongs { get; set; }

        public virtual LoaiXe LoaiXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoXeRa> SoXeRas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoXeVao> SoXeVaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuaChua> SuaChuas { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
