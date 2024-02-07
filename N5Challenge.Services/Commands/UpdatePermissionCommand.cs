using MediatR;
using N5Challenge.WebApi.Services.DataContracts.Response;

namespace N5Challenge.WebApi.Services.Commands
{
    public record UpdatePermissionCommand(int Id, string fistName, string lastName, DateTime permssionDate, string permissionType) : IRequest<UpdatePermissionResponse>
    {
    }
}
