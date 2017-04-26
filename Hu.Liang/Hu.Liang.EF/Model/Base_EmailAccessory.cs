namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_EmailAccessory
    {
        [Key]
        [StringLength(50)]
        public string EmailAccessoryId { get; set; }

        [StringLength(50)]
        public string EmailId { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(50)]
        public string FileSize { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual Base_Email Base_Email { get; set; }
    }
}
