using Gx.Fs.Rt;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Fs.Users
{

    /// <remarks>
    ///  Family Tree User Service User
    /// </remarks>
    /// <summary>
    ///  Family Tree User Service User
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "User")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "User")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://familysearch.org/v1/", ElementName = "user")]
    public partial class User : Gx.Links.HypermediaEnabledData
    {

        private string _alternateEmail;
        private string _birthDate;
        private string _contactName;
        private string _country;
        private string _displayName;
        private string _email;
        private string _familyName;
        private string _fullName;
        private string _gender;
        private string _givenName;
        private string _helperAccessPin;
        private bool? _ldsMemberAccount;
        private bool _ldsMemberAccountSpecified;
        private string _mailingAddress;
        private string _personId;
        private string _phoneNumber;
        private string _preferredLanguage;
        private string _treeUserId;
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "alternateEmail", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "alternateEmail")]
        public string AlternateEmail
        {
            get
            {
                return this._alternateEmail;
            }
            set
            {
                this._alternateEmail = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "birthDate", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "birthDate")]
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
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "contactName", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "contactName")]
        public string ContactName
        {
            get
            {
                return this._contactName;
            }
            set
            {
                this._contactName = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "country", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "country")]
        public string Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "displayName", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "displayName")]
        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "email", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "email")]
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "familyName", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "familyName")]
        public string FamilyName
        {
            get
            {
                return this._familyName;
            }
            set
            {
                this._familyName = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fullName", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "fullName")]
        public string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                this._fullName = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "gender", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "gender")]
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
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "givenName", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "givenName")]
        public string GivenName
        {
            get
            {
                return this._givenName;
            }
            set
            {
                this._givenName = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "helperAccessPin", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "helperAccessPin")]
        public string HelperAccessPin
        {
            get
            {
                return this._helperAccessPin;
            }
            set
            {
                this._helperAccessPin = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ldsMemberAccount", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "ldsMemberAccount")]
        public bool LdsMemberAccount
        {
            get
            {
                return this._ldsMemberAccount.GetValueOrDefault();
            }
            set
            {
                this._ldsMemberAccount = value;
                this._ldsMemberAccountSpecified = true;
            }
        }

        /// <summary>
        ///  Property for the XML serializer indicating whether the "LdsMemberAccount" property should be included in the output.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Newtonsoft.Json.JsonIgnore]
        public bool LdsMemberAccountSpecified
        {
            get
            {
                return this._ldsMemberAccountSpecified;
            }
            set
            {
                this._ldsMemberAccountSpecified = value;
            }
        }

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mailingAddress", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "mailingAddress")]
        public string MailingAddress
        {
            get
            {
                return this._mailingAddress;
            }
            set
            {
                this._mailingAddress = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "personId", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "personId")]
        public string PersonId
        {
            get
            {
                return this._personId;
            }
            set
            {
                this._personId = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "phoneNumber", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "phoneNumber")]
        public string PhoneNumber
        {
            get
            {
                return this._phoneNumber;
            }
            set
            {
                this._phoneNumber = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "preferredLanguage", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "preferredLanguage")]
        public string PreferredLanguage
        {
            get
            {
                return this._preferredLanguage;
            }
            set
            {
                this._preferredLanguage = value;
            }
        }
        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "treeUserId", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "treeUserId")]
        public string TreeUserId
        {
            get
            {
                return this._treeUserId;
            }
            set
            {
                this._treeUserId = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor to accept.
         */
        public void Accept(FamilySearchPlatformModelVisitor visitor)
        {
            visitor.VisitUser(this);
        }
    }
}
