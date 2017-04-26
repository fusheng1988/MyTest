namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User
    {
        [Key]
        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        public int? InnerUser { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Secretkey { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(200)]
        public string Spell { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string OICQ { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? ChangePasswordDate { get; set; }

        public int? OpenId { get; set; }

        public int? LogOnCount { get; set; }

        public DateTime? FirstVisit { get; set; }

        public DateTime? PreviousVisit { get; set; }

        public DateTime? LastVisit { get; set; }

        [StringLength(50)]
        public string AuditStatus { get; set; }

        [StringLength(50)]
        public string AuditUserId { get; set; }

        [StringLength(50)]
        public string AuditUserName { get; set; }

        public DateTime? AuditDateTime { get; set; }

        public int? Online { get; set; }

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

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
