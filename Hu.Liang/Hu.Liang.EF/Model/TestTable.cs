namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestTable")]
    public partial class TestTable
    {
        [Key]
        public int TestId { get; set; }

        public int Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
