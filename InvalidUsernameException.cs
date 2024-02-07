namespace ClassLibrary
{
    internal partial class Program
    {
        public class InvalidUsernameException : Exception
        {
            public string Username { get; set; }
            public InvalidUsernameException(string? username) : base($"The username '{username}' is invalid ")
            {
                Username = username;
            }

            public InvalidUsernameException(string? username, string? message) : base(message)
            {
                Username = username;
            }

            public InvalidUsernameException(string? username, string? message, Exception? innerException) : base(message, innerException)
            {
                Username = username;
            }

            public InvalidUsernameException()
            {
                
            }

        }
    }
}