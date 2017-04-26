namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_ButtonPermission
    {
        [Key]
        [StringLength(50)]
        public string ButtonPermissionId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModuleButtonId { get; set; }

        public int? SortCode { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
