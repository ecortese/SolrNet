using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using NHibernate.Cfg;
using NHibernate.SolrNet.NHSearchMapping.Definition;

namespace NHibernate.SolrNet.NHSearchMapping
{
    using Type = System.Type;

    public interface ISearchMapping
    {
        ICollection<DocumentMapping> Build(Configuration cfg);
    }
}
