using MediatR;
using N5Challenge.Services;
using N5Challenge.WebApi.Models;
using N5Challenge.WebApi.Services.Commands;
using N5Challenge.WebApi.Services.DataContracts.Response;

namespace N5Challenge.WebApi.Services.Handlers
{
    public class CreatePermissionHandler : IRequestHandler<CreatePermissionCommand, CreatePermissionResponse>
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePermissionHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
        {
            _permissionRepository = permissionRepository;
            _unitOfWork = unitOfWork;

        }
        public async Task<CreatePermissionResponse> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = new Models.Permission
            {
                EmployeeFirstName = request.firstName,
                EmployeeLastName = request.lastName,
                PermissionDate = request.permissionDate,
                PermissionType = new Models.PermissionType
                {
                    Description = request.permissionType
                }
            };

            _permissionRepository.CreatePermission(permission);
            var res = await _unitOfWork.Save();

            var response = new CreatePermissionResponse
            {
                Success = true,
                PermissionId = res
            };

            return  response;
        }
    }
}
