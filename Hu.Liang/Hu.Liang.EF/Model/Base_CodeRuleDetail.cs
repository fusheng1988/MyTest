namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_CodeRuleDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodeRuleDetailId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CodeRuleId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Consted { get; set; }

        public int? AutoReset { get; set; }

        public int? FixLength { get; set; }

        [StringLength(50)]
        public string FormatStr { get; set; }

        public int? StepValue { get; set; }

        public int? InitValue { get; set; }

        public int? FLength { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string FType { get; set; }

        public int? Enabled { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortCode { get; set; }

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
