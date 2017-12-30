using System;
using System.Collections.Generic;

using NHibernate.Properties;

namespace NHibernate.SolrNet.NHSearchMapping {
    public class ContainedInMapping : PropertyMappingBase {
        public ContainedInMapping(IGetter getter) : base(getter)
        {
        }
    }
}
