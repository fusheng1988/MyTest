namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_PhoneNote
    {
        [Key]
        [StringLength(50)]
        public string PhoneNoteId { get; set; }

        [StringLength(50)]
        public string PhonenNumber { get; set; }

        [StringLength(200)]
        public string SendContent { get; set; }

        public DateTime? SendTime { get; set; }

        [StringLength(50)]
        public string SendStatus { get; set; }

        [StringLength(200)]
        public string DeviceName { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
