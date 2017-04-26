namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_BackupJob
    {
        [Key]
        [StringLength(50)]
        public string BackupId { get; set; }

        [StringLength(50)]
        public string ServerName { get; set; }

        [StringLength(50)]
        public string DbName { get; set; }

        [StringLength(200)]
        public string JobName { get; set; }

        [StringLength(50)]
        public string Mode { get; set; }

        [StringLength(50)]
        public string StartTime { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [StringLength(20)]
        public string Enabled { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
