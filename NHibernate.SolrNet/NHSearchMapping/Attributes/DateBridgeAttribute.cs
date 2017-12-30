using NHibernate.SolrNet.NHSearchMapping.Definition;
using System;

namespace NHibernate.SolrNet.NHSearchMapping.Attributes
{
    /// <summary>
    /// Defines the temporal resolution of a given field
    /// Date are stored as String in GMT
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class DateBridgeAttribute : Attribute, IDateBridgeDefinition
    {
        private readonly Resolution resolution;

        public DateBridgeAttribute(Resolution resolution)
        {
            this.resolution = resolution;
        }

        public Resolution Resolution
        {
            get { return resolution; }
        }
    }
}