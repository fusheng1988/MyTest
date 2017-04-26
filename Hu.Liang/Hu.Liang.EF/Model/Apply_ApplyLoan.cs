namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_ApplyLoan
    {
        [Key]
        [StringLength(50)]
        public string ApplyLoanId { get; set; }

        [StringLength(50)]
        public string ApplyLoanNo { get; set; }

        public decimal? ApplyLoanMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Enabled { get; set; }

        public int Operate { get; set; }
    }
}
