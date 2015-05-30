using Gx.Common;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Conclusion
{

    /// <remarks>
    ///  A set of display properties for the convenience of quick display, such as for
    ///  a Web-based application. All display properties are provided in the default locale for the current
    ///  application context and are NOT considered canonical for the purposes of data exchange.
    /// </remarks>
    /// <summary>
    ///  A set of display properties for the convenience of quick display, such as for
    ///  a Web-based application. All display properties are provided in the default locale for the current
    ///  application context and are NOT considered canonical for the purposes of data exchange.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "DisplayProperties")]
    public partial class DisplayProperties : Gx.Common.ExtensibleData
    {

        private string _ascendancyNumber;
        private string _birthDate;
        private string _birthPlace;
        private string _deathDate;
        private string _deathPlace;
        private string _descendancyNumber;
        private string _gender;
        private string _lifespan;
        private string _marriageDate;
        private string _marriagePlace;
        private string _name;
        /// <summary>
        ///  The context-specific ascendancy number for the person in relation to the other persons in the request. The ancestry number is defined using the Ahnentafel numbering system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ascendancyNumber", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("ascendancyNumber")]
        public string AscendancyNumber
        {
            get
            {
                return this._ascendancyNumber;
            }
            set
            {
                this._ascendancyNumber = value;
            }
        }
        /// <summary>
        ///  The displayable label for the birth date of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "birthDate", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("birthDate")]
        public string BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }
        /// <summary>
        ///  The displayable label for the birth place of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "birthPlace", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("birthPlace")]
        public string BirthPlace
        {
            get
            {
                return this._birthPlace;
            }
            set
            {
                this._birthPlace = value;
            }
        }
        /// <summary>
        ///  The displayable label for the death date of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "deathDate", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("deathDate")]
        public string DeathDate
        {
            get
            {
                return this._deathDate;
            }
            set
            {
                this._deathDate = value;
            }
        }
        /// <summary>
        ///  The displayable label for the death place of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "deathPlace", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("deathPlace")]
        public string DeathPlace
        {
            get
            {
                return this._deathPlace;
            }
            set
            {
                this._deathPlace = value;
            }
        }
        /// <summary>
        ///  The context-specific descendancy number for the person in relation to the other persons in the request. The descendancy number is defined using the d'Aboville numbering system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "descendancyNumber", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("descendancyNumber")]
        public string DescendancyNumber
        {
            get
            {
                return this._descendancyNumber;
            }
            set
            {
                this._descendancyNumber = value;
            }
        }
        /// <summary>
        ///  The displayable label for the gender of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "gender", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("gender")]
        public string Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
        /// <summary>
        ///  The displayable label for the lifespan of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lifespan", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("lifespan")]
        public string Lifespan
        {
            get
            {
                return this._lifespan;
            }
            set
            {
                this._lifespan = value;
            }
        }
        /// <summary>
        ///  The displayable label for the marriage date of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "marriageDate", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("marriageDate")]
        public string MarriageDate
        {
            get
            {
                return this._marriageDate;
            }
            set
            {
                this._marriageDate = value;
            }
        }
        /// <summary>
        ///  The displayable label for the marriage place of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "marriagePlace", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("marriagePlace")]
        public string MarriagePlace
        {
            get
            {
                return this._marriagePlace;
            }
            set
            {
                this._marriagePlace = value;
            }
        }
        /// <summary>
        ///  The displayable name of the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        protected internal override void Embed(ExtensibleData data)
        {
            var value = (DisplayProperties)data;
            this._name = this._name == null ? value._name : this._name;
            this._gender = this._gender == null ? value._gender : this._gender;
            this._lifespan = this._lifespan == null ? value._lifespan : this._lifespan;
            this._birthDate = this._birthDate == null ? value._birthDate : this._birthDate;
            this._birthPlace = this._birthPlace == null ? value._birthPlace : this._birthPlace;
            this._deathDate = this._deathDate == null ? value._deathDate : this._deathDate;
            this._deathPlace = this._deathPlace == null ? value._deathPlace : this._deathPlace;
            this._marriageDate = this._marriageDate == null ? value._marriageDate : this._marriageDate;
            this._marriagePlace = this._marriagePlace == null ? value._marriagePlace : this._marriagePlace;
            this._ascendancyNumber = this._ascendancyNumber == null ? value._ascendancyNumber : this._ascendancyNumber;
            this._descendancyNumber = this._descendancyNumber == null ? value._descendancyNumber : this._descendancyNumber;
            base.Embed(data);
        }

        /**
         * Build up these properties with a name.
         *
         * @param name The name.
         * @return this.
         */
        public DisplayProperties SetName(String name)
        {
            Name = name;
            return this;
        }

        /**
         * Build up these properties with a gender.
         *
         * @param gender The gender.
         * @return this.
         */
        public DisplayProperties SetGender(String gender)
        {
            Gender = gender;
            return this;
        }

        /**
         * Build up these properties with a lifespan.
         *
         * @param lifespan The lifespan.
         * @return this.
         */
        public DisplayProperties SetLifespan(String lifespan)
        {
            Lifespan = lifespan;
            return this;
        }

        /**
         * Build up these properties with a birth date.
         *
         * @param birthdate The birth date.
         * @return this.
         */
        public DisplayProperties SetBirthDate(String birthdate)
        {
            BirthDate = birthdate;
            return this;
        }

        /**
         * Build up these properties with a birth place.
         *
         * @param birthplace The birth place.
         * @return this.
         */
        public DisplayProperties SetBirthPlace(String birthplace)
        {
            BirthPlace = birthplace;
            return this;
        }

        /**
         * Build up these properties with a death date.
         *
         * @param deathdate The death date.
         * @return this.
         */
        public DisplayProperties SetDeathDate(String deathdate)
        {
            DeathDate = deathdate;
            return this;
        }

        /**
         * Build up these properties with a death place.
         *
         * @param deathplace The death place.
         * @return this.
         */
        public DisplayProperties SetDeathPlace(String deathplace)
        {
            DeathPlace = deathplace;
            return this;
        }

        /**
         * Build up these properties with a marriage date.
         *
         * @param marriagedate The marriage date.
         * @return this.
         */
        public DisplayProperties SetMarriageDate(String marriagedate)
        {
            MarriageDate = marriagedate;
            return this;
        }

        /**
         * Build up these properties with a marriage place.
         *
         * @param marriageplace The marriage place.
         * @return this.
         */
        public DisplayProperties SetMarriagePlace(String marriageplace)
        {
            MarriagePlace = marriageplace;
            return this;
        }

        /**
         * Build up these properties with a ascendancy number.
         *
         * @param ascendancynumber The ascendancy number.
         * @return this.
         */
        public DisplayProperties SetAscendancyNumber(String ascendancynumber)
        {
            AscendancyNumber = ascendancynumber;
            return this;
        }

        /**
         * Build up these properties with a descendancy number.
         *
         * @param descendancynumber The descendancy number.
         * @return this.
         */
        public DisplayProperties SetDescendancyNumber(String descendancynumber)
        {
            DescendancyNumber = descendancynumber;
            return this;
        }
    }
}
