namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Product_Module_Relation
    {
        [Key]
        [StringLength(50)]
        public string ProductModuleRelationId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateName { get; set; }

        public int IsEnable { get; set; }
    }
}
