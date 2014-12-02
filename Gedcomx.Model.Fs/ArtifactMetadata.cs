using Gedcomx.Model.Util;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Fs.Artifacts
{

    /// <remarks>
    ///  FamilySearch-specific metadata about an artifact.
    /// </remarks>
    /// <summary>
    ///  FamilySearch-specific metadata about an artifact.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "ArtifactMetadata")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "ArtifactMetadata")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://familysearch.org/v1/", ElementName = "artifactMetadata")]
    public partial class ArtifactMetadata
    {

        private string _artifactType;
        private string _filename;
        private int? _height;
        private bool _heightSpecified;
        private int? _width;
        private bool _widthSpecified;
        /// <summary>
        ///  The type of the gender.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "artifactType")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "artifactType")]
        [Newtonsoft.Json.JsonProperty("artifactType")]
        public string ArtifactType
        {
            get
            {
                return this._artifactType;
            }
            set
            {
                this._artifactType = value;
            }
        }

        /// <summary>
        ///  Convenience property for treating ArtifactType as an enum. See Gx.Fs.Artifacts.ArtifactTypeQNameUtil for details on getter/setter functionality.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [Newtonsoft.Json.JsonIgnore]
        public Gx.Fs.Artifacts.ArtifactType KnownArtifactType
        {
            get
            {
                return XmlQNameEnumUtil.GetEnumValue<ArtifactType>(this._artifactType);
            }
            set
            {
                this._artifactType = XmlQNameEnumUtil.GetNameValue(value);
            }
        }
        /// <summary>
        ///  The original filename of the memories item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "filename", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "filename")]
        [Newtonsoft.Json.JsonProperty("filename")]
        public string Filename
        {
            get
            {
                return this._filename;
            }
            set
            {
                this._filename = value;
            }
        }
        /// <summary>
        ///  The height of the artifact (presumably an image).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "height", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "height")]
        [Newtonsoft.Json.JsonProperty("height")]
        public int Height
        {
            get
            {
                return this._height.GetValueOrDefault();
            }
            set
            {
                this._height = value;
                this._heightSpecified = true;
            }
        }

        /// <summary>
        ///  Property for the XML serializer indicating whether the "Height" property should be included in the output.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Newtonsoft.Json.JsonIgnore]
        public bool HeightSpecified
        {
            get
            {
                return this._heightSpecified;
            }
            set
            {
                this._heightSpecified = value;
            }
        }

        /// <summary>
        ///  The width of the artifact (presumably an image).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "width", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "width")]
        [Newtonsoft.Json.JsonProperty("width")]
        public int Width
        {
            get
            {
                return this._width.GetValueOrDefault();
            }
            set
            {
                this._width = value;
                this._widthSpecified = true;
            }
        }

        /// <summary>
        ///  Property for the XML serializer indicating whether the "Width" property should be included in the output.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Newtonsoft.Json.JsonIgnore]
        public bool WidthSpecified
        {
            get
            {
                return this._widthSpecified;
            }
            set
            {
                this._widthSpecified = value;
            }
        }

    }
}
