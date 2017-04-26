namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_InterfaceManageParameter
    {
        [Key]
        [StringLength(50)]
        public string InterfaceParameterId { get; set; }

        [StringLength(50)]
        public string InterfaceId { get; set; }

        [StringLength(50)]
        public string Field { get; set; }

        [StringLength(200)]
        public string FieldMemo { get; set; }

        [StringLength(50)]
        public string FieldType { get; set; }

        public int? FieldMaxLength { get; set; }

        public int? AllowNull { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public virtual Base_InterfaceManage Base_InterfaceManage { get; set; }
    }
}
