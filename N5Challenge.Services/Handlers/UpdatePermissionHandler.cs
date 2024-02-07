using MediatR;
using N5Challenge.Services;
using N5Challenge.WebApi.Services.Commands;
using N5Challenge.WebApi.Services.DataContracts.Response;

namespace N5Challenge.WebApi.Services.Handlers
{
    public class UpdatePermissionHandler : IRequestHandler<UpdatePermissionCommand, UpdatePermissionResponse>
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePermissionHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
        {
            _permissionRepository = permissionRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdatePermissionResponse> Handle(UpdatePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = new Models.Permission()
            {
                Id = request.Id,
                EmployeeFirstName = request.fistName,
                EmployeeLastName = request.fistName,
                PermissionDate = request.permssionDate,
                PermissionType = new Models.PermissionType
                {
                    Description = request.permissionType
                }
            };
            _permissionRepository.ModifyPermission(permission);
            var result = await _unitOfWork.Save();

            var response = new UpdatePermissionResponse
            {
                Success = true,
                PermissionId = result
            };

            return response;
        }
    }
}
