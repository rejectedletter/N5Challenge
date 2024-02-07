using N5Challenge.WebApi.Services.DataContracts.Response;

namespace N5Challenge.Services
{
    public interface IPermissionRepository
    {
       void CreatePermission(WebApi.Models.Permission permission);
       IEnumerable<WebApi.Models.Permission> GetPermissions();
       void ModifyPermission(WebApi.Models.Permission permission);
    }
}
