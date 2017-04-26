namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Email
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Base_Email()
        {
            Base_EmailAccessory = new HashSet<Base_EmailAccessory>();
            Base_EmailAddressee = new HashSet<Base_EmailAddressee>();
        }

        [Key]
        [StringLength(50)]
        public string EmailId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(200)]
        public string Theme { get; set; }

        [StringLength(50)]
        public string ThemeColour { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [StringLength(50)]
        public string Addresser { get; set; }

        public DateTime? SendDate { get; set; }

        public int? IsAccessory { get; set; }

        public int? Priority { get; set; }

        public int? Receipt { get; set; }

        public int? IsDelayed { get; set; }

        public DateTime? DelayedTime { get; set; }

        public int? State { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Base_EmailAccessory> Base_EmailAccessory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Base_EmailAddressee> Base_EmailAddressee { get; set; }
    }
}
