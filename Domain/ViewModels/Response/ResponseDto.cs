namespace Domain.ViewModels.Response
{
    public sealed class ResponseDto
    {
        public object Model { get; set; }
        public bool HasWarning { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; } = "";
        public Dictionary<string, object> Metadata { get; set; } = new();

        public static ResponseDto Success(object model = null, string message = "")
        {
            return new ResponseDto
            {
                Model = model,
                HasWarning = false,
                HasError = false,
                Message = message
            };
        }

        public static ResponseDto Warning(string message, object model = null)
        {
            return new ResponseDto
            {
                Model = model,
                HasWarning = true,
                HasError = false,
                Message = message
            };
        }

        public static ResponseDto Error(string message, object model = null)
        {
            return new ResponseDto
            {
                Model = model,
                HasWarning = false,
                HasError = true,
                Message = message
            };
        }
    }
}
