namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Supplies
    {
        [Key]
        [StringLength(50)]
        public string SupplierId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(50)]
        public string Fax { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountsMethod { get; set; }

        [Required]
        [StringLength(50)]
        public string LinkMan { get; set; }

        [Required]
        [StringLength(50)]
        public string LeadingOfficialId { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }
    }
}
