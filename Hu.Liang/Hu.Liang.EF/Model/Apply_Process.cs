namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Process
    {
        [Key]
        [StringLength(50)]
        public string ProcessId { get; set; }

        [StringLength(50)]
        public string ProcessName { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime CreatTime { get; set; }

        public int Enabled { get; set; }

        [Required]
        [StringLength(50)]
        public string Remark { get; set; }
    }
}
