using Gedcomx.Model.Rt;
using Gedcomx.Model.Util;
using Gx.Types;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace Gx.Records
{

    /// <remarks>
    ///  A field of a record.
    /// </remarks>
    /// <summary>
    ///  A field of a record.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Field")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Field")]
    public partial class Field : Gx.Links.HypermediaEnabledData
    {

        private string _type;
        private System.Collections.Generic.List<Gx.Records.FieldValue> _values;
        /// <summary>
        ///  The type of the gender.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        /// <summary>
        ///  Convenience property for treating Type as an enum. See Gx.Types.FieldTypeQNameUtil for details on getter/setter functionality.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [Newtonsoft.Json.JsonIgnore]
        public Gx.Types.FieldType KnownType
        {
            get
            {
                return XmlQNameEnumUtil.GetEnumValue<FieldType>(this._type);
            }
            set
            {
                this._type = XmlQNameEnumUtil.GetNameValue(value);
            }
        }
        /// <summary>
        ///  The set of values for the field.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "value", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "value")]
        [Newtonsoft.Json.JsonProperty("values")]
        public System.Collections.Generic.List<Gx.Records.FieldValue> Values
        {
            get
            {
                return this._values;
            }
            set
            {
                this._values = value;
            }
        }

        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitField(this);
        }

        /**
         * Build out this field with a type.
         * 
         * @param type The type.
         * @return this.
         */
        public Field SetType(String type)
        {
            Type = type;
            return this;
        }

        /**
         * Build out this field with a type.
         * 
         * @param type The type.
         * @return this.
         */
        public Field SetType(FieldType type)
        {
            KnownType = type;
            return this;
        }

        /**
         * Build out this field with a field value.
         * @param value The value.
         * @return this.
         */
        public Field SetValue(FieldValue value)
        {
            AddValue(value);
            return this;
        }

        /**
         * Add a reference to the record value values being used as evidence.
         *
         * @param value The value to be added.
         */
        public void AddValue(FieldValue value)
        {
            if (value != null)
            {
                if (_values == null)
                {
                    _values = new List<FieldValue>();
                }
                _values.Add(value);
            }
        }
    }
}
