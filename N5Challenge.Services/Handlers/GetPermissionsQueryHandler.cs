using MediatR;
using N5Challenge.Services;
using N5Challenge.WebApi.Services.DataContracts.Response;
using N5Challenge.WebApi.Services.Queries;

namespace N5Challenge.WebApi.Services.Handlers
{
    public class GetPermissionsQueryHandler : IRequestHandler<GetPermissionsQuery, GetPermissionsResponse>
    {
        private readonly IPermissionRepository _repository;

        public GetPermissionsQueryHandler(IPermissionRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetPermissionsResponse> Handle(GetPermissionsQuery request, CancellationToken cancellationToken)
        {
            var permissions = _repository.GetPermissions().ToList().Select(p => new Permission
            {
                Id = p.Id,
                EmployeeFirstName = p.EmployeeFirstName,
                EmployeeLastName = p.EmployeeLastName,
                PermissionDate = p.PermissionDate,
                PermissionType = new PermissionType { Description = p.PermissionType.Description }
            });

            var response = new GetPermissionsResponse
            {
                Permissions = permissions.ToList()
            };

            return response;
        }
    }
}
