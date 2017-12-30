using SolrNet.Schema;
using System;

namespace NHibernate.SolrNet.Bridge
{
    /// <summary>
    /// Bridge to use a TwoWayStringBridge as a TwoWayFieldBridge
    /// </summary>
    public class TwoWayString2FieldBridgeAdaptor : String2FieldBridgeAdaptor, ITwoWayFieldBridge
    {
        private readonly ITwoWayStringBridge stringBridge;

        public TwoWayString2FieldBridgeAdaptor(ITwoWayStringBridge stringBridge) : base(stringBridge)
        {
            this.stringBridge = stringBridge;
        }

        #region ITwoWayFieldBridge Members

        public object Get(String name, SolrSchema document)
        {
            throw new NotSupportedException();
            //Field field = document.GetField(name);
            //if (field == null)
            //{
            //    return null;
            //}

            //return stringBridge.StringToObject(field.StringValue);
        }

        public string ObjectToString(object obj)
        {
            return stringBridge.ObjectToString(obj);
        }

        #endregion
    }
}