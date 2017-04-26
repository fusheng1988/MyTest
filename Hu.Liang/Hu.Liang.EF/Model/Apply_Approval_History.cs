namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Approval_History
    {
        [Key]
        [StringLength(50)]
        public string ApprovalHistory { get; set; }

        [Required]
        [StringLength(50)]
        public string ApplyLoanId { get; set; }

        [Required]
        [StringLength(50)]
        public string ApprovalUserId { get; set; }

        public DateTime ApprovalTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Remark { get; set; }

        public int Operate { get; set; }
    }
}
