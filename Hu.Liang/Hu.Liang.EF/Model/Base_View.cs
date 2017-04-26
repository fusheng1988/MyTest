namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_View
    {
        [Key]
        [StringLength(50)]
        public string ViewId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string ShowName { get; set; }

        public int? ColumnWidth { get; set; }

        [StringLength(50)]
        public string TextAlign { get; set; }

        public int? AllowShow { get; set; }

        public int? AllowDerive { get; set; }

        public string CustomSwitch { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
