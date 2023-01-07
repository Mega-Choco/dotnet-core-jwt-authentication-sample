using System.Net;

namespace jwt_authentication_sample.Exceptions
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public string? Title { get; set; }

        public ApiException(int statusCode, string? message, string? title) : this(statusCode, message)
        {
            Title = title;
        }

        public ApiException(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ApiException(string message) { Message = message; }

        public ApiException(int statusCode) { StatusCode = statusCode; }
    }
}
