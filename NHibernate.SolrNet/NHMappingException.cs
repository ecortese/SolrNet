using System;
using System.Runtime.Serialization;

namespace NHibernate.SolrNet
{
    [Serializable]
    public class NHMappingException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NHMappingException() { }
        public NHMappingException(string message) : base(message) { }
        public NHMappingException(string message, Exception inner) : base(message, inner) { }

        protected NHMappingException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) { }
    }
}