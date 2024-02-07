namespace N5Challenge.WebApi.Services.DataContracts.Response
{
    public class Permission
    {
        public int Id { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public DateTime PermissionDate { get; set; }

        public PermissionType PermissionType { get; set; }
    }
}
