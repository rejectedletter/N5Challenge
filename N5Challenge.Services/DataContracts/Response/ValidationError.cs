namespace N5Challenge.WebApi.Services.DataContracts.Response
{
    public enum ErrorSeverity
    {
        Error,
        Warning
    }
    public class ValidationError
    {
        private ValidationError(ErrorSeverity severity, string message)
        {
            Severity = severity;
            Message = message;
        }

        public string Message { get; private set; }
        public ErrorSeverity Severity { get; private set; }

        internal static ValidationError CreateError(string message)
        {
            return new ValidationError(ErrorSeverity.Error, message);
        }
    }
}
