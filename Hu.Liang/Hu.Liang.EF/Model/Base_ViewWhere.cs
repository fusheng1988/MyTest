namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_ViewWhere
    {
        [Key]
        [StringLength(50)]
        public string ViewWhereId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ControlType { get; set; }

        [StringLength(200)]
        public string ControlDefault { get; set; }

        [StringLength(200)]
        public string ControlSource { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string ShowName { get; set; }

        public int? AllowShow { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(200)]
        public string ControlCustom { get; set; }
    }
}
