using MediatR;
using Microsoft.AspNetCore.Mvc;
using N5Challenge.WebApi.Services.Commands;
using N5Challenge.WebApi.Services.Queries;
using N5Challenge.WebApi.Services.DataContracts.Response;
using Serilog;

namespace N5Challenge.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissionController : ControllerBase
    {
         private readonly IMediator _mediator;

        public PermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetPermissions")]
        public GetPermissionsResponse GetAll()
        {
            return _mediator.Send(new GetPermissionsQuery()).Result;
        }

        [HttpPost(Name = "CreatePermission")]
        public CreatePermissionResponse Create(CreatePermissionCommand command)
        {
            var permissionDto = _mediator.Send(command);

            Log.Information("Permission Created");
            return permissionDto.Result;
        }

        [HttpPut(Name = "ModifyPermission")]
        public UpdatePermissionResponse Update(UpdatePermissionCommand command)
        {
            var result = _mediator.Send(command);

            Log.Information($"Permission {command.Id} Updated");
            return result.Result;
        }
    }
}
