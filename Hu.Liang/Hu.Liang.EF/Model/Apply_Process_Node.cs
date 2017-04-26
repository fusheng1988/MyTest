namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apply_Process_Node
    {
        [Key]
        [StringLength(50)]
        public string ProcessNodeId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcessId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcessNodeName { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevNode { get; set; }

        [Required]
        [StringLength(50)]
        public string NextNode { get; set; }

        public DateTime CreateTime { get; set; }

        public int Enabled { get; set; }
    }
}
