namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Product
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductProcessId { get; set; }

        public int ProductTerm { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime CreateTime { get; set; }

        public int Enabled { get; set; }

        [Required]
        [StringLength(200)]
        public string Remark { get; set; }
    }
}
