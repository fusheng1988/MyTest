namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_NetworkFolder
    {
        [Key]
        [StringLength(50)]
        public string FolderId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(200)]
        public string FolderName { get; set; }

        public int? IsPublic { get; set; }

        public int? Sharing { get; set; }

        [StringLength(50)]
        public string SharingFolderId { get; set; }

        public DateTime? SharingCreateDate { get; set; }

        public DateTime? SharingEndDate { get; set; }

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
