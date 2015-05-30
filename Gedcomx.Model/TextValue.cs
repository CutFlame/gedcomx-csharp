// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Common
{

    /// <remarks>
    ///  An element representing a text value that may be in a specific language.
    /// </remarks>
    /// <summary>
    ///  An element representing a text value that may be in a specific language.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "TextValue")]
    public partial class TextValue
    {
        private string _lang;
        private string _value;

        public TextValue()
        {
        }

        public TextValue(String value)
        {
            this._value = value;
        }

        /// <summary>
        ///  The language of the text value.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        [Newtonsoft.Json.JsonProperty("lang")]
        public string Lang
        {
            get
            {
                return this._lang;
            }
            set
            {
                this._lang = value;
            }
        }
        /// <summary>
        ///  The text value.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }

        /**
         * Build up this text value with a lang.
         *
         * @param lang The lang.
         * @return this.
         */
        public TextValue SetLang(String lang)
        {
            Lang = lang;
            return this;
        }

        /**
         * Build up this text value with a value.
         *
         * @param value The value.
         * @return this.
         */
        public TextValue SetValue(String value)
        {
            Value = value;
            return this;
        }
    }
}
