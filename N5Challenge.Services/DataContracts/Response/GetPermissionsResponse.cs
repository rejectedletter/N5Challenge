namespace N5Challenge.WebApi.Services.DataContracts.Response
{
    public class GetPermissionsResponse : BaseResponse
    {
        public List<Permission> Permissions { get; set; }
    }
}
