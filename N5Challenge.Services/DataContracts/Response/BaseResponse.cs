using System.Runtime.Serialization;

namespace N5Challenge.WebApi.Services.DataContracts.Response
{
    public class BaseResponse
    {
        [DataMember]
        public IEnumerable<ValidationError> Errors { get; set; }

        [DataMember]
        public bool Success { get; set; }

        public void AddError(string message)
        {
            _errors.Add(ValidationError.CreateError(message));
        }

        internal void AddErrors(IEnumerable<ValidationError> errors)
        {
            _errors.AddRange(errors);
        }

        private readonly List<ValidationError> _errors = new List<ValidationError>();
    }
}
