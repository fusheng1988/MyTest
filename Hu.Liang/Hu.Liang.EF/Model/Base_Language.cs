namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Language
    {
        [Key]
        [StringLength(50)]
        public string LanguageId { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(50)]
        public string BusinessCode { get; set; }

        [StringLength(50)]
        public string BusinessName { get; set; }

        [Column(TypeName = "text")]
        public string FullName { get; set; }

        [StringLength(200)]
        public string FullValue { get; set; }

        public string Note { get; set; }

        [StringLength(50)]
        public string LanguageType { get; set; }
    }
}
