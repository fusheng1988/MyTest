namespace Hu.Liang.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HuLiang : DbContext
    {
        public HuLiang()
            : base("name=HuLiang")
        {
        }

        public virtual DbSet<Apply_ApplyLoan> Apply_ApplyLoan { get; set; }
        public virtual DbSet<Apply_Approval_History> Apply_Approval_History { get; set; }
        public virtual DbSet<Apply_Contacts> Apply_Contacts { get; set; }
        public virtual DbSet<Apply_Current_Approval> Apply_Current_Approval { get; set; }
        public virtual DbSet<Apply_Customer> Apply_Customer { get; set; }
        public virtual DbSet<Apply_Module> Apply_Module { get; set; }
        public virtual DbSet<Apply_Process> Apply_Process { get; set; }
        public virtual DbSet<Apply_Process_Node> Apply_Process_Node { get; set; }
        public virtual DbSet<Apply_Product> Apply_Product { get; set; }
        public virtual DbSet<Apply_Product_Module_Relation> Apply_Product_Module_Relation { get; set; }
        public virtual DbSet<Base_BackupJob> Base_BackupJob { get; set; }
        public virtual DbSet<Base_Button> Base_Button { get; set; }
        public virtual DbSet<Base_ButtonPermission> Base_ButtonPermission { get; set; }
        public virtual DbSet<Base_CodeRule> Base_CodeRule { get; set; }
        public virtual DbSet<Base_CodeRuleDetail> Base_CodeRuleDetail { get; set; }
        public virtual DbSet<Base_CodeRuleSerious> Base_CodeRuleSerious { get; set; }
        public virtual DbSet<Base_Company> Base_Company { get; set; }
        public virtual DbSet<Base_DataDictionary> Base_DataDictionary { get; set; }
        public virtual DbSet<Base_DataDictionaryDetail> Base_DataDictionaryDetail { get; set; }
        public virtual DbSet<Base_DataScopePermission> Base_DataScopePermission { get; set; }
        public virtual DbSet<Base_Department> Base_Department { get; set; }
        public virtual DbSet<Base_Email> Base_Email { get; set; }
        public virtual DbSet<Base_EmailAccessory> Base_EmailAccessory { get; set; }
        public virtual DbSet<Base_EmailAddressee> Base_EmailAddressee { get; set; }
        public virtual DbSet<Base_EmailCategory> Base_EmailCategory { get; set; }
        public virtual DbSet<Base_Employee> Base_Employee { get; set; }
        public virtual DbSet<Base_ExcelImport> Base_ExcelImport { get; set; }
        public virtual DbSet<Base_ExcelImportDetail> Base_ExcelImportDetail { get; set; }
        public virtual DbSet<Base_FormAttribute> Base_FormAttribute { get; set; }
        public virtual DbSet<Base_FormAttributeValue> Base_FormAttributeValue { get; set; }
        public virtual DbSet<Base_GroupUser> Base_GroupUser { get; set; }
        public virtual DbSet<Base_InterfaceManage> Base_InterfaceManage { get; set; }
        public virtual DbSet<Base_InterfaceManageParameter> Base_InterfaceManageParameter { get; set; }
        public virtual DbSet<Base_Language> Base_Language { get; set; }
        public virtual DbSet<Base_Module> Base_Module { get; set; }
        public virtual DbSet<Base_ModulePermission> Base_ModulePermission { get; set; }
        public virtual DbSet<Base_NetworkFile> Base_NetworkFile { get; set; }
        public virtual DbSet<Base_NetworkFolder> Base_NetworkFolder { get; set; }
        public virtual DbSet<Base_ObjectUserRelation> Base_ObjectUserRelation { get; set; }
        public virtual DbSet<Base_PhoneNote> Base_PhoneNote { get; set; }
        public virtual DbSet<Base_Post> Base_Post { get; set; }
        public virtual DbSet<Base_ProvinceCity> Base_ProvinceCity { get; set; }
        public virtual DbSet<Base_QueryRecord> Base_QueryRecord { get; set; }
        public virtual DbSet<Base_Roles> Base_Roles { get; set; }
        public virtual DbSet<Base_Shortcuts> Base_Shortcuts { get; set; }
        public virtual DbSet<Base_Supplies> Base_Supplies { get; set; }
        public virtual DbSet<Base_SysLog> Base_SysLog { get; set; }
        public virtual DbSet<Base_SysLogDetail> Base_SysLogDetail { get; set; }
        public virtual DbSet<Base_User> Base_User { get; set; }
        public virtual DbSet<Base_View> Base_View { get; set; }
        public virtual DbSet<Base_ViewPermission> Base_ViewPermission { get; set; }
        public virtual DbSet<Base_ViewWhere> Base_ViewWhere { get; set; }
        public virtual DbSet<Base_ViewWherePermission> Base_ViewWherePermission { get; set; }
        public virtual DbSet<POOrder> POOrder { get; set; }
        public virtual DbSet<POOrderEntry> POOrderEntry { get; set; }
        public virtual DbSet<TestTable> TestTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apply_ApplyLoan>()
                .Property(e => e.ApplyLoanId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_ApplyLoan>()
                .Property(e => e.ApplyLoanNo)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_ApplyLoan>()
                .Property(e => e.ApplyLoanMoney)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Apply_ApplyLoan>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_ApplyLoan>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_ApplyLoan>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Approval_History>()
                .Property(e => e.ApprovalHistory)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Approval_History>()
                .Property(e => e.ApplyLoanId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Approval_History>()
                .Property(e => e.ApprovalUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Approval_History>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.ContactsId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.ContactsName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.ContactsPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.ContactsAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.CreateUsername)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Contacts>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Current_Approval>()
                .Property(e => e.CurrentApproval)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Current_Approval>()
                .Property(e => e.ApprovalUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Current_Approval>()
                .Property(e => e.ApplyLoanId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Current_Approval>()
                .Property(e => e.ApprovaLEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Current_Approval>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.HouseIp)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.Marriage)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.SpousePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.SpouseAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.SpouseName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.CreateUserID)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Customer>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Module>()
                .Property(e => e.ApplyModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Module>()
                .Property(e => e.ApplyModuleName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Module>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Module>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Module>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Module>()
                .Property(e => e.Enabled)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process>()
                .Property(e => e.ProcessId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process>()
                .Property(e => e.ProcessName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.ProcessNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.ProcessId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.ProcessNodeName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.PrevNode)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Process_Node>()
                .Property(e => e.NextNode)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product>()
                .Property(e => e.ProductProcessId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product_Module_Relation>()
                .Property(e => e.ProductModuleRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product_Module_Relation>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product_Module_Relation>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product_Module_Relation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Apply_Product_Module_Relation>()
                .Property(e => e.CreateName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.BackupId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.DbName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.JobName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Enabled)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.JsEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ActionEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ButtonPermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ModuleButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CodeRuleDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.Consted)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FormatStr)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CodeSeriousId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.LastUpdateDate)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ProvinceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CountyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.AccountInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Postalcode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.DataDictionaryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.DataDictionaryDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.DataDictionaryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.DataScopePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ResourceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ScopeType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Theme)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.ThemeColour)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Addresser)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .HasMany(e => e.Base_EmailAccessory)
                .WithOptional(e => e.Base_Email)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_Email>()
                .HasMany(e => e.Base_EmailAddressee)
                .WithOptional(e => e.Base_Email)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.EmailAccessoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.EmailAddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.AddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.AddresseeName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.EmailCategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.EmployeeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Photograph)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.IDCard)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeCornet)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeFax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.School)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Major)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeFax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.NativePlace)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Party)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Nation)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Duty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.WorkingProperty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Competency)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.EmergencyContact)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.DimissionCause)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.DimissionWhither)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportTable)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportTableName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportFileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ImportDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ImportId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ForeignTable)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.BackField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CompareField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.AttachCondition)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.FieldRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.FormAttributeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlStyle)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlValidator)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.DefaultVlaue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.AttributesProperty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.DataSource)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlColspan)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.AttributeValueId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ObjectParameterJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.GroupUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.InterfaceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Constraints)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .HasMany(e => e.Base_InterfaceManageParameter)
                .WithOptional(e => e.Base_InterfaceManage)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.InterfaceParameterId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.InterfaceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.FieldMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.FieldType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.LanguageId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.FullValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.LanguageType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ModulePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.NetworkFileId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileExtensions)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.SharingFolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.FolderName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.SharingFolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.ObjectUserRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.PhoneNoteId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.PhonenNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.SendContent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.SendStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.DeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.PostId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ProvinceCityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.QueryRecordId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.ShortcutsId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.AccountsMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.LeadingOfficialId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.SysLogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.LogType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.IPAddressName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .HasMany(e => e.Base_SysLogDetail)
                .WithOptional(e => e.Base_SysLog)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.SysLogDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.SysLogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.PropertyField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.NewValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.OldValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Secretkey)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Spell)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.OICQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.TextAlign)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.CustomSwitch)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ViewPermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ViewWhereId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlDefault)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlSource)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlCustom)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewWherePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewWhereDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.POOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.BillNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Clearing)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FetchAdd)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.SalesmanId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Salesman)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateDepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyDepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.AuditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.AuditStatusName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.POOrderEntryId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.POOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemModel)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.UnitId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable>()
                .Property(e => e.Remark)
                .IsUnicode(false);
        }
    }
}
