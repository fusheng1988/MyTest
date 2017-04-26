namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POOrderEntry")]
    public partial class POOrderEntry
    {
        [StringLength(50)]
        public string POOrderEntryId { get; set; }

        [StringLength(50)]
        public string POOrderId { get; set; }

        [StringLength(50)]
        public string BatchNo { get; set; }

        [StringLength(50)]
        public string ItemId { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(200)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ItemModel { get; set; }

        [StringLength(50)]
        public string UnitId { get; set; }

        public decimal? Qty { get; set; }

        public decimal? Price { get; set; }

        public decimal? PriceAmount { get; set; }

        public decimal? PlusPrice { get; set; }

        public decimal? PlusPriceAmount { get; set; }

        public decimal? CESS { get; set; }

        public decimal? CESSAmount { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
