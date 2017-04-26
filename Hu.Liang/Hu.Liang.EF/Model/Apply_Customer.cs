namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Customer
    {
        [Key]
        [StringLength(50)]
        public string CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(20)]
        public string CardType { get; set; }

        [Required]
        [StringLength(50)]
        public string CardNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(200)]
        public string HouseIp { get; set; }

        [StringLength(5)]
        public string Sex { get; set; }

        public int? Age { get; set; }

        [StringLength(5)]
        public string Education { get; set; }

        [StringLength(5)]
        public string Marriage { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string SpousePhone { get; set; }

        [StringLength(50)]
        public string SpouseAddress { get; set; }

        [StringLength(50)]
        public string SpouseName { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserID { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime CreateTime { get; set; }

        public int IsEnable { get; set; }

        [Required]
        [StringLength(200)]
        public string Remark { get; set; }
    }
}
