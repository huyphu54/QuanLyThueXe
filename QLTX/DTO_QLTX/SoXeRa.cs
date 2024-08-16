namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoXeRa")]
    public partial class SoXeRa
    {
        [Key]
        public int MaXeRa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayRa { get; set; }

        [StringLength(100)]
        public string ChuThich { get; set; }

        public int? MaXe { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
