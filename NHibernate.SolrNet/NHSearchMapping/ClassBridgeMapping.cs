using NHibernate.SolrNet.NHSearchMapping.Attributes;
using NHibernate.SolrNet.Bridge;

namespace NHibernate.SolrNet.NHSearchMapping
{
    public class ClassBridgeMapping
    {
        public ClassBridgeMapping(string name, IFieldBridge bridge)
        {
            this.Name = name;
            this.Bridge = bridge;

            this.Store = Attributes.Store.No;
            this.Index = Attributes.Index.Tokenized;
        }

        public string Name              { get; private set; }
        public IFieldBridge Bridge      { get; private set; }
        
        public float? Boost             { get; set; }
        //public Analyzer Analyzer        { get; set; }
        public Attributes.Store Store   { get; set; }
        public Index Index              { get; set; }
    }
}
