namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_CodeRuleSerious
    {
        [Key]
        [StringLength(50)]
        public string CodeSeriousId { get; set; }

        [StringLength(50)]
        public string CodeRuleId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        public int? ValueType { get; set; }

        public int? NowValue { get; set; }

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

        [StringLength(20)]
        public string LastUpdateDate { get; set; }
    }
}
