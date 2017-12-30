using SolrNet.Schema;

namespace NHibernate.SolrNet.Bridge
{
    /// <summary>
    /// Link between a .NET property and a Lucene Document
    /// Usually a .NET property will be linked to a Document Field
    /// </summary>
    /// TODO: should show Field or document - document is nice since I can save an object into several fields
    public interface IFieldBridge
    {
        /// <summary>
        /// Manipulate the document to index the given value.
        /// A common implementation is to add a Field <code>name</code> to the given document following
        /// the parameters (<code>store</code>, <code>index</code>, <code>boost</code>) if the
        /// <code>value</code> is not null
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="document"></param>
        ///// <param name="store"></param>
        ///// <param name="index"></param>
        /// <param name="boost"></param>
        void Set(string name, object value, SolrSchema document, /*Field.Store store, Field.Index index,*/ float? boost);
    }
}