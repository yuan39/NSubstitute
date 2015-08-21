using System;
#if NET4 || NET45
using System.Runtime.Serialization;
#endif

namespace NSubstitute.Exceptions
{
    public class AmbiguousArgumentsException : SubstituteException
    {
        public static string SpecifyAllArguments = "Cannot determine argument specifications to use." + Environment.NewLine +
                                                    "Please use specifications for all arguments of the same type.";
        public AmbiguousArgumentsException() : this(SpecifyAllArguments) { }
        public AmbiguousArgumentsException(string message) : base(message) { }
#if NET4 || NET45
        protected AmbiguousArgumentsException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
    }
}