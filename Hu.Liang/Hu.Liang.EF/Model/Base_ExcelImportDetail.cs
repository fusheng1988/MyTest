namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_ExcelImportDetail
    {
        [Key]
        [StringLength(50)]
        public string ImportDetailId { get; set; }

        [StringLength(50)]
        public string ImportId { get; set; }

        [StringLength(50)]
        public string ColumnName { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(200)]
        public string ForeignTable { get; set; }

        [StringLength(200)]
        public string BackField { get; set; }

        [StringLength(200)]
        public string CompareField { get; set; }

        [StringLength(200)]
        public string AttachCondition { get; set; }

        public int? DataType { get; set; }

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

        [StringLength(50)]
        public string FieldRemark { get; set; }
    }
}
