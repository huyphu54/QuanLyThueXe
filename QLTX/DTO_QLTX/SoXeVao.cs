namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoXeVao")]
    public partial class SoXeVao
    {
        [Key]
        public int MaXeVao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayVao { get; set; }

        [StringLength(100)]
        public string ChuThich { get; set; }

        public int? MaXe { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
