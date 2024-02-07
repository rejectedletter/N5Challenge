using MediatR;
using N5Challenge.WebApi.Services.DataContracts.Response;

namespace N5Challenge.WebApi.Services.Commands
{
    public record CreatePermissionCommand(string firstName, string lastName, DateTime permissionDate, string permissionType) : IRequest<CreatePermissionResponse>
    {
       
    }
}
