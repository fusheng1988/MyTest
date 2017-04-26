namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_EmailAddressee
    {
        [Key]
        [StringLength(50)]
        public string EmailAddresseeId { get; set; }

        [StringLength(50)]
        public string EmailId { get; set; }

        [StringLength(50)]
        public string AddresseeId { get; set; }

        [StringLength(50)]
        public string AddresseeName { get; set; }

        public int? AddresseeIdState { get; set; }

        public int? IsRead { get; set; }

        public int? ReadCount { get; set; }

        public DateTime? ReadDate { get; set; }

        public DateTime? EndReadDate { get; set; }

        public int? Highlight { get; set; }

        public int? Backlog { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? DeleteMark { get; set; }

        public virtual Base_Email Base_Email { get; set; }
    }
}
