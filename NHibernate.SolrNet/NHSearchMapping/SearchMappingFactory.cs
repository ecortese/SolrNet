using System;

using NHibernate.Cfg;
using NHibernate.SolrNet.NHSearchMapping.AttributeBased;
using NHibernate.Util;

namespace NHibernate.SolrNet.NHSearchMapping
{
    public static class SearchMappingFactory 
    {
        public const string MappingClassPropertyName = "hibernate.search.mapping";

        public static ISearchMapping CreateMapping(Configuration cfg)
        {
            System.Type mappingClass = GetMappingClass(cfg.GetProperty(MappingClassPropertyName));

            object instance;
            try
            {
                instance = Activator.CreateInstance(mappingClass);
            }
            catch (Exception ex)
            {
                throw new NHMappingException(
                    "Could not create search mapping class '" + mappingClass.FullName + "'.", ex
                );
            }

            if (!(instance is ISearchMapping))
            {
                throw new NHMappingException(string.Format(
                    "Search mapping class '{0}' does not implement '{1}'.",
                    mappingClass.FullName, typeof(ISearchMapping).FullName
                ));
            }

            return (ISearchMapping)instance;
        }

        private static System.Type GetMappingClass(string mappingClassName) {
            if (mappingClassName == null)
                return typeof(AttributeSearchMapping);

            try
            {
                return ReflectHelper.ClassForName(mappingClassName);
            }
            catch (Exception e)
            {
                throw new NHMappingException(
                    string.Format("Search mapping class '{0}' defined in property '{1}' could not be found.", mappingClassName, MappingClassPropertyName)
                    , e);
            }
        }
    }
}
