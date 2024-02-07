using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace N5Challenge.WebApi.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public PermissionType PermissionType { get; set; }

        public int PermissionTypeId { get; set; }
        public DateTime PermissionDate { get; set; }
    }
}
