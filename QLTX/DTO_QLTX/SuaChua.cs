namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuaChua")]
    public partial class SuaChua
    {
        [Key]
        public int MaSuaChua { get; set; }

        public DateTime? NgaySua { get; set; }

        [StringLength(100)]
        public string TinhTrang { get; set; }

        public double? ChiPhi { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? MaXe { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
