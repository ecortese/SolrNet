using System;

using NHibernate.SolrNet.NHSearchMapping.Attributes;

namespace NHibernate.SolrNet.NHSearchMapping.Definition {
    public interface IDateBridgeDefinition {
        Resolution Resolution { get; }
    }
}
