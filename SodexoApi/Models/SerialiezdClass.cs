//namespace SodexoApi.Models
//{
//    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
//    public class CostCenter
//    {
//        public string Id { get; set; }
//        public object NameFr { get; set; }
//        public object NameNl { get; set; }
//        public int MatriculeCRD { get; set; }
//        public bool IsStructure { get; set; }
//        public string BE000031 { get; set; }
//        public string BE000076 { get; set; }
//        public string BE000084 { get; set; }
//        public string BE000090 { get; set; }
//        public string BE000098 { get; set; }
//        public string BE000104 { get; set; }
//        public string BE000107 { get; set; }
//        public string BE000250 { get; set; }
//        public string BE000438 { get; set; }
//        public string BE001690 { get; set; }

//        [JsonProperty("6082")]
//        public string _6082 { get; set; }
//    }

//    public class HrContractRole
//    {
//        public bool IsLevel1 { get; set; }
//        public bool IsLevel2 { get; set; }
//        public bool IsClusterManagerOrCateringSuperVisor { get; set; }
//        public bool IsLevel3 { get; set; }
//        public bool IsLevel1OrSecretary { get; set; }
//        public bool IsLevel123OrSecretary { get; set; }
//        public bool IsAllowIndividualStatement { get; set; }
//        public bool IsAllowCreateAddendum { get; set; }
//        public bool IsAllowContractPayAddendum { get; set; }
//        public bool IsAllowCreateContractWSAddendum { get; set; }
//        public bool IsAllowPastContract { get; set; }
//        public bool IsAllowSendTimeAddendum { get; set; }
//        public bool IsAllowCDIO { get; set; }
//        public bool IsAllow32Bis { get; set; }
//        public bool IsSuperUser { get; set; }
//        public bool IsPayrollAdminOrSuperUser { get; set; }
//    }

//    public class Member
//    {
//        public int Id { get; set; }
//        public int ProfitCenterId { get; set; }
//        public int OrganizationalUnitId { get; set; }
//        public object Lastname { get; set; }
//        public string Firstname { get; set; }
//        public DateTime DateContractTo { get; set; }
//        public bool IsStructure { get; set; }
//        public object PersonalArea { get; set; }
//        public object Mail { get; set; }
//        public object Company { get; set; }
//        public int Lang { get; set; }
//        public List<CostCenter> CostCenters { get; set; }
//        public DateTime DateFrom { get; set; }
//        public DateTime DateTo { get; set; }
//        public object Role { get; set; }
//        public string Shl { get; set; }
//        public int Right { get; set; }
//        public bool IsProfitCenterMain { get; set; }
//        public object ProfitCenterName { get; set; }
//    }

//    public class OrganizationalUnit
//    {
//        public int Language { get; set; }
//        public DateTime DateFrom { get; set; }
//        public DateTime DateTo { get; set; }
//        public string HISTO { get; set; }
//        public string ISTAT { get; set; }
//        public string OTYPE { get; set; }
//        public string PLVAR { get; set; }
//        public string REALO { get; set; }
//        public string SHORT { get; set; }
//        public bool ToDelete { get; set; }
//        public int Id { get; set; }
//        public int ProfitCenterId { get; set; }
//        public string Description { get; set; }
//        public object CompanyCode { get; set; }
//    }

//    public class PersonalOperational
//    {
//        public object _Id2ObjectSerialized { get; set; }
//        public object _Id3ObjectSerialized { get; set; }
//        public object _Id4ObjectSerialized { get; set; }
//        public int Id { get; set; }
//        public int TypeId { get; set; }
//        public string Id2 { get; set; }
//        public string Id3 { get; set; }
//        public object Id4 { get; set; }
//        public int CountryId { get; set; }
//        public bool Disable { get; set; }
//    }

//    public class ProfitCenters
//    {
//    }

//    public class Root
//    {
//        public User User { get; set; }
//        public object LoginDeducted { get; set; }
//        public int Language { get; set; }
//        public string Right { get; set; }
//        public string RightString { get; set; }
//        public object CostCentersAllowedToAssigned { get; set; }
//        public object ClientName { get; set; }
//        public object MailsExtensionAllowToManage { get; set; }
//        public int Browser { get; set; }
//        public object BrowserVersion { get; set; }
//        public bool IsResourceEditable { get; set; }
//        public bool IsGrantManagementAccess { get; set; }
//        public object Ip { get; set; }
//        public bool ConnectedWithoutSSO { get; set; }
//        public SapRole SapRole { get; set; }
//        public SapRoleLeavePlanner SapRoleLeavePlanner { get; set; }
//        public ProfitCenters ProfitCenters { get; set; }
//        public bool HasHierarchy { get; set; }
//    }

//    public class SapRole
//    {
//        public int Matricule { get; set; }
//        public string UserName { get; set; }
//        public object Name { get; set; }
//        public string RoleInSap { get; set; }
//        public int RoleLeavePlannerInSap { get; set; }
//        public object FirstLanguageIntoSap { get; set; }
//        public object ProfitCenterId { get; set; }
//        public CostCenters CostCenters { get; set; }
//        public List<object> OrganizationalUnits { get; set; }
//        public List<object> Members { get; set; }
//        public bool IsAllowChangeAccess { get; set; }
//        public int Role { get; set; }
//        public string RoleString { get; set; }
//        public HrContractRole HrContractRole { get; set; }
//    }

//    public class SapRoleLeavePlanner
//    {
//        public int Matricule { get; set; }
//        public string UserName { get; set; }
//        public string Name { get; set; }
//        public string RoleInSap { get; set; }
//        public int RoleLeavePlannerInSap { get; set; }
//        public string FirstLanguageIntoSap { get; set; }
//        public string ProfitCenterId { get; set; }
//        public CostCenters CostCenters { get; set; }
//        public List<OrganizationalUnit> OrganizationalUnits { get; set; }
//        public List<Member> Members { get; set; }
//        public bool IsAllowChangeAccess { get; set; }
//        public int Role { get; set; }
//        public string RoleString { get; set; }
//        public HrContractRole HrContractRole { get; set; }
//    }

//    public class User
//    {
//        public List<object> CostCentersSap { get; set; }
//        public List<object> CostCentersManual { get; set; }
//        public List<PersonalOperational> PersonalOperationals { get; set; }
//        public List<UserRole> UserRoles { get; set; }
//        public List<UserResource> UserResources { get; set; }
//        public List<object> UserApplications { get; set; }
//        public bool IsFromSAPHR { get; set; }
//        public bool IsFromSodexoMain { get; set; }
//        public bool HasAlreadySiteManagerInHierarchy { get; set; }
//        public int Level { get; set; }
//        public object Responsible { get; set; }
//        public object Replacement { get; set; }
//        public DateTime Birthdate { get; set; }
//        public string Tel { get; set; }
//        public string Lastname2 { get; set; }
//        public string Firstname2 { get; set; }
//        public string City { get; set; }
//        public string PostCode { get; set; }
//        public string Street { get; set; }
//        public string StreetNumber { get; set; }
//        public string Country { get; set; }
//        public int CivilStatus { get; set; }
//        public int Genre { get; set; }
//        public DateTime SSO_LoginDate { get; set; }
//        public string SSO_Otp { get; set; }
//        public string Password { get; set; }
//        public object MailsExtensionAllowToManage { get; set; }
//        public object ClientName { get; set; }
//        public bool MustWhosWho { get; set; }
//        public DateTime DateCreation { get; set; }
//        public DateTime DateLastUpdate { get; set; }
//        public DateTime DatePassword { get; set; }
//        public int Id { get; set; }
//        public int Matricule { get; set; }
//        public string Firstname { get; set; }
//        public string Lastname { get; set; }
//        public string Mail { get; set; }
//        public int ProfitCenterId { get; set; }
//        public int HierarchyLevel { get; set; }
//        public int CountryId { get; set; }
//        public bool Disable { get; set; }
//        public DateTime DateIn { get; set; }
//        public object DateOut { get; set; }
//        public string FunctionId { get; set; }
//        public int LanguageId { get; set; }
//        public string Function { get; set; }
//        public object Gsm { get; set; }
//        public string Organization { get; set; }
//        public int CompanyId { get; set; }
//        public DateTime DateContractFrom { get; set; }
//        public DateTime DateContractTo { get; set; }
//        public string CompanyCode { get; set; }
//        public string PersonalArea { get; set; }
//        public string ControllingArea { get; set; }
//        public string OrganizationalUnit { get; set; }
//        public string Position { get; set; }
//        public string Job { get; set; }
//        public string FunctionId2 { get; set; }
//        public string EmployeeGroup { get; set; }
//        public string EmployeeSubgroup { get; set; }
//        public string PayrollArea { get; set; }
//        public string PersonalSubArea { get; set; }
//        public bool IsStructure { get; set; }
//        public bool IsMatriculeInHierarchy { get; set; }
//        public int ResponsibleId { get; set; }
//        public int ReplacementId { get; set; }
//        public object ReplacementDate { get; set; }
//        public int TypeId { get; set; }
//    }

//    public class UserResource
//    {
//        public object _Id2ObjectSerialized { get; set; }
//        public object _Id3ObjectSerialized { get; set; }
//        public object _Id4ObjectSerialized { get; set; }
//        public int Id { get; set; }
//        public int TypeId { get; set; }
//        public string Id2 { get; set; }
//        public string Id3 { get; set; }
//        public object Id4 { get; set; }
//        public int CountryId { get; set; }
//        public bool Disable { get; set; }
//    }

//    public class UserRole
//    {
//        public object _Id2ObjectSerialized { get; set; }
//        public string _Id3ObjectSerialized { get; set; }
//        public object _Id4ObjectSerialized { get; set; }
//        public int Id { get; set; }
//        public int TypeId { get; set; }
//        public string Id2 { get; set; }
//        public string Id3 { get; set; }
//        public object Id4 { get; set; }
//        public int CountryId { get; set; }
//        public bool Disable { get; set; }
//    }


//}
