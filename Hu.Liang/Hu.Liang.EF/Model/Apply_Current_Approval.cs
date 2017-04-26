namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Current_Approval
    {
        [Key]
        [StringLength(50)]
        public string CurrentApproval { get; set; }

        [Required]
        [StringLength(50)]
        public string ApprovalUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string ApplyLoanId { get; set; }

        public DateTime ArrvialTime { get; set; }

        [Required]
        [StringLength(50)]
        public string ApprovaLEndTime { get; set; }

        [Required]
        [StringLength(200)]
        public string Remark { get; set; }
    }
}
