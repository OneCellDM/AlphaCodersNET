using System;

namespace WallsAlphaCodersLib
{
    public class ApiException : Exception
    {
        public ApiException() : base()
        {
        }

        public ApiException(string message) : base(message)
        {
        }
    }
}