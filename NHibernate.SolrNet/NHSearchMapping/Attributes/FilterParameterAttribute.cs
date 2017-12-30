namespace NHibernate.SolrNet.NHSearchMapping.Attributes
{
    using System;

    /// <summary>
    /// Defines a parameter on a filter
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FilterParameterAttribute : Attribute
    {
    }
}