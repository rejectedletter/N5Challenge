using MediatR;
using N5Challenge.WebApi.Services.DataContracts.Response;

namespace N5Challenge.WebApi.Services.Queries
{
    public record GetPermissionsQuery : IRequest<GetPermissionsResponse>
    {
    }
}
