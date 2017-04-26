namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Company
    {
        [Key]
        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string Nature { get; set; }

        [StringLength(50)]
        public string Manager { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string ProvinceId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string CityId { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string CountyId { get; set; }

        [StringLength(50)]
        public string County { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(200)]
        public string AccountInfo { get; set; }

        [StringLength(200)]
        public string Postalcode { get; set; }

        [StringLength(200)]
        public string Web { get; set; }

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
