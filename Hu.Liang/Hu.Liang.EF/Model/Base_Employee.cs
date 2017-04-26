namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Employee
    {
        [Key]
        [StringLength(50)]
        public string EmployeeId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string Photograph { get; set; }

        [StringLength(50)]
        public string IDCard { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string BankCode { get; set; }

        [StringLength(50)]
        public string OfficeCornet { get; set; }

        [StringLength(50)]
        public string OfficePhone { get; set; }

        [StringLength(50)]
        public string OfficeZipCode { get; set; }

        [StringLength(200)]
        public string OfficeAddress { get; set; }

        [StringLength(50)]
        public string OfficeFax { get; set; }

        [StringLength(50)]
        public string Education { get; set; }

        [StringLength(50)]
        public string School { get; set; }

        public DateTime? GraduationDate { get; set; }

        [StringLength(50)]
        public string Major { get; set; }

        [StringLength(50)]
        public string Degree { get; set; }

        public DateTime? WorkingDate { get; set; }

        [StringLength(50)]
        public string HomeZipCode { get; set; }

        [StringLength(200)]
        public string HomeAddress { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string HomeFax { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string NativePlace { get; set; }

        [StringLength(50)]
        public string Party { get; set; }

        [StringLength(50)]
        public string Nation { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string Duty { get; set; }

        [StringLength(50)]
        public string WorkingProperty { get; set; }

        [StringLength(50)]
        public string Competency { get; set; }

        [StringLength(50)]
        public string EmergencyContact { get; set; }

        public int? IsDimission { get; set; }

        public DateTime? DimissionDate { get; set; }

        [StringLength(200)]
        public string DimissionCause { get; set; }

        [StringLength(50)]
        public string DimissionWhither { get; set; }
    }
}
