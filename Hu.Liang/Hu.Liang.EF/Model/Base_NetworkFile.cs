namespace Hu.Liang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_NetworkFile
    {
        [Key]
        [StringLength(50)]
        public string NetworkFileId { get; set; }

        [StringLength(50)]
        public string FolderId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(50)]
        public string FileSize { get; set; }

        [StringLength(50)]
        public string FileExtensions { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

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
    }
}
