using NHibernate.Cfg;
using NHibernate.SolrNet.NHSearchMapping;
using SolrNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.SolrNet.Mapping
{
    public class NHSearchMappingManager : IReadOnlyMappingManager
    {
        protected ISearchMapping searchMappingFactory;

        public NHSearchMappingManager(Configuration cfg)
        {
            searchMappingFactory = SearchMappingFactory.CreateMapping(cfg);
        }

        public IDictionary<string, SolrFieldModel> GetFields(System.Type type)
        {
            throw new NotImplementedException();
        }

        public ICollection<System.Type> GetRegisteredTypes()
        {
            throw new NotImplementedException();
        }

        public SolrFieldModel GetUniqueKey(System.Type type)
        {
            throw new NotImplementedException();
        }
    }
}
