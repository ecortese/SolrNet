using System;
using System.Collections.Generic;

namespace NHibernate.SolrNet.NHSearchMapping.Definition {
    public interface IFieldBridgeDefinition 
    {
        System.Type Impl                      { get; }
        Dictionary<string, object> Parameters { get; }
    }
}
