using System;

namespace Oborotov
{
    public class OborotovException : Exception
    {
        public OborotovException(string message)
        : base(message)
        { }
    }
}