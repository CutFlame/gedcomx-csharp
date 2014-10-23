using Gedcomx.Model.Rt;
using Gx.Records;
using Gx.Types;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace Gx.Conclusion
{

    /// <remarks>
    ///  A form of a name.
    /// </remarks>
    /// <summary>
    ///  A form of a name.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "NameForm")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "NameForm")]
    public partial class NameForm : Gx.Common.ExtensibleData
    {
        private string _lang;
        private string _fullText;
        private System.Collections.Generic.List<Gx.Conclusion.NamePart> _parts;
        private System.Collections.Generic.List<Gx.Records.Field> _fields;

        public NameForm()
        {
        }

        public NameForm(String fullText, params NamePart[] parts)
        {
            this.FullText = fullText;
            foreach (NamePart part in parts)
            {
                AddPart(part);
            }
        }

        /// <summary>
        ///  The language of the conclusion.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
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
        ///  The full text of the name form.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fullText", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "fullText")]
        [Newtonsoft.Json.JsonProperty("fullText")]
        public string FullText
        {
            get
            {
                return this._fullText;
            }
            set
            {
                this._fullText = value;
            }
        }
        /// <summary>
        ///  The different parts of the name form.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "part", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "part")]
        [Newtonsoft.Json.JsonProperty("parts")]
        public System.Collections.Generic.List<Gx.Conclusion.NamePart> Parts
        {
            get
            {
                return this._parts;
            }
            set
            {
                this._parts = value;
            }
        }
        /// <summary>
        ///  The references to the record fields being used as evidence.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "field", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "field")]
        [Newtonsoft.Json.JsonProperty("fields")]
        public System.Collections.Generic.List<Gx.Records.Field> Fields
        {
            get
            {
                return this._fields;
            }
            set
            {
                this._fields = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitNameForm(this);
        }

        /**
         * Build up this name form with a lang.
         *
         * @param lang The lang.
         * @return this.
         */
        public NameForm SetLang(String lang)
        {
            Lang = lang;
            return this;
        }

        /**
         * Build up this name form with full text.
         *
         * @param fullText The full text.
         * @return this
         */
        public NameForm SetFullText(String fullText)
        {
            FullText = fullText;
            return this;
        }

        /**
         * Build up this name form with a part.
         *
         * @param part The part.
         * @return this.
         */
        public NameForm SetPart(NamePart part)
        {
            AddPart(part);
            return this;
        }

        /**
         * Build up this name form with a part.
         *
         * @param partType The part type.
         * @param value The value.
         * @return this.
         */
        public NameForm SetPart(NamePartType partType, String value)
        {
            AddPart(new NamePart(partType, value));
            return this;
        }

        /**
         * Build up this name form with a field.
         *
         * @param field The field.
         * @return this.
         */
        public NameForm SetField(Field field)
        {
            AddField(field);
            return this;
        }

        /**
         * Add a name part the list of name parts for this name form.
         *
         * @param part The name part to be added.
         */
        public void AddPart(NamePart part)
        {
            if (part != null)
            {
                if (_parts == null)
                {
                    _parts = new List<NamePart>();
                }
                _parts.Add(part);
            }
        }

        /**
         * Add a reference to the record field values being used as evidence.
         *
         * @param field The field to be added.
         */
        public void AddField(Field field)
        {
            if (field != null)
            {
                if (_fields == null)
                {
                    _fields = new List<Field>();
                }
                _fields.Add(field);
            }
        }
    }
}
