namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_FormAttributeValue
    {
        [Key]
        [StringLength(50)]
        public string AttributeValueId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [Column(TypeName = "text")]
        public string ObjectParameterJson { get; set; }
    }
}
