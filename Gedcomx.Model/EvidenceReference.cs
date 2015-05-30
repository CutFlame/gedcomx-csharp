using Gedcomx.Model.Rt;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Common
{

    /// <remarks>
    ///  A reference to a resource that is being used as evidence.
    /// </remarks>
    /// <summary>
    ///  A reference to a resource that is being used as evidence.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "EvidenceReference")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "evidenceReference")]
    public sealed partial class EvidenceReference : Gx.Links.HypermediaEnabledData, IAttributable
    {
        private string _resourceId;
        private string _resource;
        private Gx.Common.Attribution _attribution;

        public EvidenceReference()
        {
        }

        public EvidenceReference(String resource)
        {
            this.Resource = resource;
        }
        
        /// <summary>
        ///  The resource id of the resource being referenced.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "resourceId")]
        [Newtonsoft.Json.JsonProperty("resourceId")]
        public string ResourceId
        {
            get
            {
                return this._resourceId;
            }
            set
            {
                this._resourceId = value;
            }
        }
        /// <summary>
        ///  The URI to the resource.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "resource")]
        [Newtonsoft.Json.JsonProperty("resource")]
        public string Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
            }
        }
        /// <summary>
        ///  Attribution metadata for evidence reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attribution", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("attribution")]
        public Gx.Common.Attribution Attribution
        {
            get
            {
                return this._attribution;
            }
            set
            {
                this._attribution = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(IGedcomxModelVisitor visitor)
        {
            visitor.VisitEvidenceReference(this);
        }

        /**
         * Build up this reference with a resource id.
         *
         * @param resourceId The resource id.
         */
        public EvidenceReference SetResourceId(String resourceId)
        {
            this.ResourceId = resourceId;
            return this;
        }

        /**
         * Build up this reference with a resource URI.
         *
         * @param resource The resource.
         */
        public EvidenceReference SetResource(String resource)
        {
            this.Resource = resource;
            return this;
        }

        /**
         * Build up this evidence reference with an attribution.
         *
         * @param attribution The attribution.
         * @return this.
         */
        public EvidenceReference SetAttribution(Attribution attribution)
        {
            this.Attribution = attribution;
            return this;
        }
    }
}
