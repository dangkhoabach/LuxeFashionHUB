namespace ClothStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            CT_HoaDon = new HashSet<CT_HoaDon>();
        }

        [Key]
        public int MaHoaDon { get; set; }

        public DateTime? NgayLap { get; set; }

        public long? TongTien { get; set; }

        public bool? TrangThai { get; set; }

        public bool? ThanhToan { get; set; }

        public bool? GiaoHang { get; set; }

        [StringLength(100)]
        public string DiaChiGiao { get; set; }

        [Required]
        [StringLength(128)]
        public string Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HoaDon> CT_HoaDon { get; set; }
    }
}
