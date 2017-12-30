using NHibernate.Properties;
using NHibernate.SolrNet.Bridge;

namespace NHibernate.SolrNet.NHSearchMapping
{
    public class FieldMapping : PropertyMappingBase
    {
        public FieldMapping(string name, IFieldBridge bridge, IGetter getter) : base(getter)
        {
            this.Name = name;
            this.Bridge = bridge;

            this.Store = Attributes.Store.No;
            this.Index = Attributes.Index.Tokenized;
        }

        public string Name { get; private set; }
        public IFieldBridge Bridge { get; private set; }
        public float? Boost { get; set; }
        public Attributes.Store Store { get; set; }
        public Attributes.Index Index { get; set; }
        //public Analyzer Analyzer        { get; set; }
    }
}
