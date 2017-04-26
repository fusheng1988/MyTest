namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Module
    {
        [Key]
        [StringLength(50)]
        public string ApplyModuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string ApplyModuleName { get; set; }

        public int IsMultiple { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [Required]
        [StringLength(50)]
        public string Enabled { get; set; }
    }
}
