namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_FormAttribute
    {
        [Key]
        [StringLength(50)]
        public string FormAttributeId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string PropertyName { get; set; }

        [StringLength(50)]
        public string ControlId { get; set; }

        [StringLength(50)]
        public string ControlType { get; set; }

        [StringLength(50)]
        public string ControlStyle { get; set; }

        [StringLength(50)]
        public string ControlValidator { get; set; }

        public int? ImportLength { get; set; }

        [StringLength(50)]
        public string DefaultVlaue { get; set; }

        public string AttributesProperty { get; set; }

        public int? DataSourceType { get; set; }

        public string DataSource { get; set; }

        [StringLength(50)]
        public string ControlColspan { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
