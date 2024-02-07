using Microsoft.EntityFrameworkCore;
using N5Challenge.Services;
using N5Challenge.WebApi.Services.DataContracts.Response;
using N5Company.WebApi.Data;

namespace N5Challenge.WebApi.Services
{
    public class PermissionRepository : IPermissionRepository
    {

        private ApplicationDbContext _context;
        public PermissionRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreatePermission(Models.Permission permission)
        {
            var result = new CreatePermissionResponse();

            try
            {
               var per = _context.Permissions.Add(permission);
            }
            catch (Exception)
            {

                throw;
            }
        }

       public IEnumerable<Models.Permission> GetPermissions()
        {
            return _context.Permissions
                .Include(x => x.PermissionType).ToList();
        }

        public void ModifyPermission(Models.Permission permission)
        {
            try
            {
                _context.Permissions.Update(permission);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
