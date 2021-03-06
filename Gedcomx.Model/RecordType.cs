// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Types
{

    /// <remarks>
    ///  Enumeration of known record types.
    /// </remarks>
    /// <summary>
    ///  Enumeration of known record types.
    /// </summary>
    public enum RecordType
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute(Name = "__NULL__")]
        [System.Xml.Serialization.SoapEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///   A record of a person's admission to an institution, society, or other association.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Admission")]
        Admission,

        /// <summary>
        ///   A record of an adoption.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Adoption")]
        Adoption,

        /// <summary>
        ///   An affidavit.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Affidavit")]
        Affidavit,

        /// <summary>
        ///   A person's application to an institution, society or other association.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Application")]
        Application,

        /// <summary>
        ///   A record of a person's arrival at a certain place.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Arrival")]
        Arrival,

        /// <summary>
        ///   A bank record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Bank")]
        Bank,

        /// <summary>
        ///   A record of a person's baptism.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Baptism")]
        Baptism,

        /// <summary>
        ///   A record of a birth.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Birth")]
        Birth,

        /// <summary>
        ///   A record of a person's burial or interment.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Burial")]
        Burial,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Business")]
        Business,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Cemetery")]
        Cemetery,

        /// <summary>
        ///   A census record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Census")]
        Census,

        /// <summary>
        ///   A record of a person's christening.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Christening")]
        Christening,

        /// <summary>
        ///   A record of a person's confirmation.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Confirmation")]
        Confirmation,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Correspondence")]
        Correspondence,

        /// <summary>
        ///   A death record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Death")]
        Death,

        /// <summary>
        ///   A record of a person's departure from a certain place.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Departure")]
        Departure,

        /// <summary>
        ///   A divorce record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Divorce")]
        Divorce,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Duplicate")]
        Duplicate,

        /// <summary>
        ///   A draft record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Draft")]
        Draft,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Estate")]
        Estate,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Index")]
        Index,

        /// <summary>
        ///   todo: document this type. what's the difference between this an MarrigeBanns?
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/IntendedMarriage")]
        IntendedMarriage,

        /// <summary>
        ///   A land record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Land")]
        Land,

        /// <summary>
        ///   A legal record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Legal")]
        Legal,

        /// <summary>
        ///   A marriage record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Marriage")]
        Marriage,

        /// <summary>
        ///   A marriage affadavit. todo: is this distinguishment necessary? why not just use Marriage?
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageAffidavit")]
        MarriageAffidavit,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageAmendment")]
        MarriageAmendment,

        /// <summary>
        ///   A record of a person's banns of marriage.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageBanns")]
        MarriageBanns,

        /// <summary>
        ///   todo: document this type. why not just use marriage banns?
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageConsent")]
        MarriageConsent,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageDuplicate")]
        MarriageDuplicate,

        /// <summary>
        ///   A marriage license. todo: is this distinguishment necessary? why not just use Marriage?
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageLicense")]
        MarriageLicense,

        /// <summary>
        ///   todo: document this type. is this distinguishment necessary? why not just use Marriage?
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageReturns")]
        MarriageReturns,

        /// <summary>
        ///   todo: document this type. is this distinguishment necessary?
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Membership")]
        Membership,

        /// <summary>
        ///   A migration record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Migration")]
        Migration,

        /// <summary>
        ///   A military record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Military")]
        Military,

        /// <summary>
        ///   A naturalization record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Naturalization")]
        Naturalization,

        /// <summary>
        ///   A passenger record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Passenger")]
        Passenger,

        /// <summary>
        ///   A pension record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Pension")]
        Pension,

        /// <summary>
        ///   A probate record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Probate")]
        Probate,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/RelatedDocument")]
        RelatedDocument,

        /// <summary>
        ///   todo: document this type.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/ReligiousCreeds")]
        ReligiousCreeds,

        /// <summary>
        ///   A roll.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Roll")]
        Roll,

        /// <summary>
        ///   A tax record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Tax")]
        Tax,

        /// <summary>
        ///   A vital record.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Vital")]
        Vital,

        /// <summary>
        ///   Custom
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/OTHER")]
        OTHER
    }
}
