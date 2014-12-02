// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Types
{

    /// <remarks>
    ///  Enumeration of standard fact types.
    /// </remarks>
    /// <summary>
    ///  Enumeration of standard fact types.
    /// </summary>
    public enum FactType
    {

        /// <summary>
        ///  Unspecified enum value.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute(Name = "__NULL__")]
        [System.Xml.Serialization.SoapEnumAttribute(Name = "__NULL__")]
        NULL,

        /// <summary>
        ///   A fact of a person's adoption. In the context of a parent-child relationship, it describes a fact of the adoption of a child by a parent.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Adoption")]
        Adoption,

        /// <summary>
        ///   A fact of a person's christening as an adult.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/AdultChristening")]
        AdultChristening,

        /// <summary>
        ///   A fact of a person's amnesty.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Amnesty")]
        Amnesty,

        /// <summary>
        ///   A fact of a person's apprenticeship.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Apprenticeship")]
        Apprenticeship,

        /// <summary>
        ///   A fact of a person's arrest.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Arrest")]
        Arrest,

        /// <summary>
        ///   A fact of a person's baptism.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Baptism")]
        Baptism,

        /// <summary>
        ///   A fact of a person's bar mitzvah.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/BarMitzvah")]
        BarMitzvah,

        /// <summary>
        ///   A fact of a person's bat mitzvah.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/BatMitzvah")]
        BatMitzvah,

        /// <summary>
        ///   A fact of a person's birth.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Birth")]
        Birth,

        /// <summary>
        ///   A fact of an official blessing received by a person, such as at the hands of a clergy member or at another religious rite.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Blessing")]
        Blessing,

        /// <summary>
        ///   A fact of the burial of person's body after death.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Burial")]
        Burial,

        /// <summary>
        ///   A fact of a person's caste.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Caste")]
        Caste,

        /// <summary>
        ///   A fact of a person's participation in a census.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Census")]
        Census,

        /// <summary>
        ///   A fact of a person's christening *at birth*. Note: use `AdultChristening` for the christening as an adult.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Christening")]
        Christening,

        /// <summary>
        ///   A fact of a person's circumcision.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Circumcision")]
        Circumcision,

        /// <summary>
        ///   A fact of a person's clan.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Clan")]
        Clan,

        /// <summary>
        ///   A fact of a person's confirmation (or other rite of initiation) in a church or religion.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Confirmation")]
        Confirmation,

        /// <summary>
        ///   A fact of the cremation of person's body after death.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Cremation")]
        Cremation,

        /// <summary>
        ///   A fact of the death of a person.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Death")]
        Death,

        /// <summary>
        ///   A fact of an education of a person.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Education")]
        Education,

        /// <summary>
        ///   A fact of a person's enrollment in an educational program or institution.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/EducationEnrollment")]
        EducationEnrollment,

        /// <summary>
        ///   A fact of the emigration of a person.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Emigration")]
        Emigration,

        /// <summary>
        ///   A fact of a person's ethnicity or race.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Ethnicity")]
        Ethnicity,

        /// <summary>
        ///   A fact of a person's excommunication from a church.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Excommunication")]
        Excommunication,

        /// <summary>
        ///   A fact of a person's first communion in a church.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/FirstCommunion")]
        FirstCommunion,

        /// <summary>
        ///   A fact of a person's funeral.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Funeral")]
        Funeral,

        /// <summary>
        ///   A fact of a person's gender change.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/GenderChange")]
        GenderChange,

        /// <summary>
        ///   A fact of a person's graduation from a scholastic institution.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Graduation")]
        Graduation,

        /// <summary>
        ///   A fact of a person's immigration.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Immigration")]
        Immigration,

        /// <summary>
        ///   A fact of a person's imprisonment.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Imprisonment")]
        Imprisonment,

        /// <summary>
        ///   A fact of a land transaction enacted by a person.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/LandTransaction")]
        LandTransaction,

        /// <summary>
        ///   A fact of a language spoken by a person.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Language")]
        Language,

        /// <summary>
        ///   A fact of a record of a person's living for a specific period. This is designed to include &quot;flourish&quot;, defined to mean the time period
        ///   in an adult's life where he was most productive, perhaps as a writer or member of the state assembly. It does not reflect the person's birth and death dates.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Living")]
        Living,

        /// <summary>
        ///   A fact of a person's marital status.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MaritalStatus")]
        MaritalStatus,

        /// <summary>
        ///   A fact of a person's medical record, such as for an illness or hospital stay.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Medical")]
        Medical,

        /// <summary>
        ///   A fact of a person's military award.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MilitaryAward")]
        MilitaryAward,

        /// <summary>
        ///   A fact of a person's military discharge.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MilitaryDischarge")]
        MilitaryDischarge,

        /// <summary>
        ///   A fact of a person's registration for a military draft.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MilitaryDraftRegistration")]
        MilitaryDraftRegistration,

        /// <summary>
        ///   A fact of a person's military induction.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MilitaryInduction")]
        MilitaryInduction,

        /// <summary>
        ///   A fact of a person's militray service.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MilitaryService")]
        MilitaryService,

        /// <summary>
        ///   A fact of a person's church mission.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Mission")]
        Mission,

        /// <summary>
        ///   A fact of a person's move (i.e. change of residence) from a location.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MoveFrom")]
        MoveFrom,

        /// <summary>
        ///   A fact of a person's move (i.e. change of residence) to a new location.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MoveTo")]
        MoveTo,

        /// <summary>
        ///   A fact that a person was born as part of a multiple birth (e.g. twin, triplet, etc.)
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MultipleBirth")]
        MultipleBirth,

        /// <summary>
        ///   A fact of a person's national id (e.g. social security number).
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/NationalId")]
        NationalId,

        /// <summary>
        ///   A fact of a person's nationality.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Nationality")]
        Nationality,

        /// <summary>
        ///   A fact of a person's naturalization (i.e. acquisition of citizenship and nationality).
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Naturalization")]
        Naturalization,

        /// <summary>
        ///   A fact of a person's number of marriages.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/NumberOfMarriages")]
        NumberOfMarriages,

        /// <summary>
        ///   A fact of a person's occupation or employment.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Occupation")]
        Occupation,

        /// <summary>
        ///   A fact of a person's ordination to a stewardship in a church.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Ordination")]
        Ordination,

        /// <summary>
        ///   A fact of a person's legal pardon.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Pardon")]
        Pardon,

        /// <summary>
        ///   A fact of a person's physical description.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/PhysicalDescription")]
        PhysicalDescription,

        /// <summary>
        ///   A fact of a receipt of probate of a person's property.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Probate")]
        Probate,

        /// <summary>
        ///   A fact of a person's property or possessions.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Property")]
        Property,

        /// <summary>
        ///   A fact of a person's religion.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Religion")]
        Religion,

        /// <summary>
        ///   A fact of a person's residence.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Residence")]
        Residence,

        /// <summary>
        ///   A fact of a person's retirement.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Retirement")]
        Retirement,

        /// <summary>
        ///   A fact of a person's stillbirth.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Stillbirth")]
        Stillbirth,

        /// <summary>
        ///   A fact of a person's tax assessment.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/TaxAssessment")]
        TaxAssessment,

        /// <summary>
        ///   A fact of a person's will.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Will")]
        Will,

        /// <summary>
        ///   A fact of a person's visit to a place different from the person's residence.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Visit")]
        Visit,

        /// <summary>
        ///   A fact of a person's _yahrzeit_ date.  A person's yahzeit is the anniversary of their death as measured by the Hebrew calendar.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Yahrzeit")]
        Yahrzeit,

        /// <summary>
        ///   The fact of an annulment of a marriage.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Annulment")]
        Annulment,

        /// <summary>
        ///   The fact of a marriage by common law.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/CommonLawMarriage")]
        CommonLawMarriage,

        /// <summary>
        ///   The fact of a civil union.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/CivilUnion")]
        CivilUnion,

        /// <summary>
        ///   The fact of a divorce of a couple.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Divorce")]
        Divorce,

        /// <summary>
        ///   The fact of a filing for divorce.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/DivorceFiling")]
        DivorceFiling,

        /// <summary>
        ///   The fact of a domestic partnership.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/DomesticPartnership")]
        DomesticPartnership,

        /// <summary>
        ///   The fact of an engagement to be married.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Engagement")]
        Engagement,

        /// <summary>
        ///   The fact of a marriage.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Marriage")]
        Marriage,

        /// <summary>
        ///   The fact of a marriage banns.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageBanns")]
        MarriageBanns,

        /// <summary>
        ///   The fact of a marriage contract.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageContract")]
        MarriageContract,

        /// <summary>
        ///   The fact of a marriage license.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageLicense")]
        MarriageLicense,

        /// <summary>
        ///   The fact of a marriage notice.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriageNotice")]
        MarriageNotice,

        /// <summary>
        ///   A fact of the number of children of a person or relationship.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/NumberOfChildren")]
        NumberOfChildren,

        /// <summary>
        ///   A fact of a couple's separation.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Separation")]
        Separation,

        /// <summary>
        ///   A fact about an adoptive relationship between a parent an a child.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/AdoptiveParent")]
        AdoptiveParent,

        /// <summary>
        ///   A fact the biological relationship between a parent and a child.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/BiologicalParent")]
        BiologicalParent,

        /// <summary>
        ///   A fact about a foster relationship between a foster parent and a child.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/FosterParent")]
        FosterParent,

        /// <summary>
        ///   A fact about a legal guardianship between a parent and a child.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/GuardianParent")]
        GuardianParent,

        /// <summary>
        ///   A fact about the step relationship between a parent and a child.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/StepParent")]
        StepParent,

        /// <summary>
        ///   A fact about a sociological relationship between a parent and a child, but not definable in typical legal or biological terms.
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/SociologicalParent")]
        SociologicalParent,

        /// <summary>
        ///  (no documentation provided)
        /// </summary>
        [System.Xml.Serialization.XmlEnum("http://gedcomx.org/OTHER")]
        OTHER
    }
}
