namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_SysLogDetail
    {
        [Key]
        [StringLength(50)]
        public string SysLogDetailId { get; set; }

        [StringLength(50)]
        public string SysLogId { get; set; }

        [StringLength(50)]
        public string PropertyName { get; set; }

        [StringLength(50)]
        public string PropertyField { get; set; }

        public string NewValue { get; set; }

        [StringLength(50)]
        public string OldValue { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual Base_SysLog Base_SysLog { get; set; }
    }
}
