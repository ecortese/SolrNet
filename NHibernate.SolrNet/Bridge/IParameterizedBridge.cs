using System.Collections.Generic;

namespace NHibernate.SolrNet.Bridge
{
    /// <summary>
    /// Allow parameter injection to a given bridge
    /// </summary>
    public interface IParameterizedBridge
    {
        void SetParameterValues(Dictionary<string, object> parameters);
    }
}