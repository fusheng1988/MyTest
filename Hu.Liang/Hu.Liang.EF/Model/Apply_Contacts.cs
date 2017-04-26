namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Contacts
    {
        [Key]
        [StringLength(50)]
        public string ContactsId { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactsName { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactsPhone { get; set; }

        public int ContactsRelation { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactsAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUsername { get; set; }

        public DateTime CreateTime { get; set; }

        public int IsEnable { get; set; }

        [Required]
        [StringLength(200)]
        public string Remark { get; set; }
    }
}
