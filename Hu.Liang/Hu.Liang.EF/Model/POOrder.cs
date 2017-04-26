namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POOrder")]
    public partial class POOrder
    {
        [StringLength(50)]
        public string POOrderId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string BillNo { get; set; }

        public DateTime? BillDate { get; set; }

        [StringLength(20)]
        public string Method { get; set; }

        [StringLength(50)]
        public string Clearing { get; set; }

        public DateTime? ClearingTime { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(50)]
        public string SupplierId { get; set; }

        [StringLength(200)]
        public string FetchAdd { get; set; }

        [StringLength(50)]
        public string SalesmanId { get; set; }

        [StringLength(50)]
        public string Salesman { get; set; }

        public int? POOrderType { get; set; }

        public int? Cancellation { get; set; }

        [StringLength(50)]
        public string CreateDepartmentId { get; set; }

        [StringLength(50)]
        public string CreateDepartmentName { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? IsSubmit { get; set; }

        public int? DeleteMark { get; set; }

        [StringLength(50)]
        public string ModifyDepartmentId { get; set; }

        [StringLength(50)]
        public string ModifyDepartmentName { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string AuditStatus { get; set; }

        [StringLength(50)]
        public string AuditStatusName { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
