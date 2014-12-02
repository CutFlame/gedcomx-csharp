// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Types {

  /// <remarks>
  ///  Enumeration of known field value types.
  /// </remarks>
  /// <summary>
  ///  Enumeration of known field value types.
  /// </summary>
  public enum FieldValueType {

    /// <summary>
    ///  Unspecified enum value.
    /// </summary>
    [System.Xml.Serialization.XmlEnumAttribute(Name="__NULL__")]
    [System.Xml.Serialization.SoapEnumAttribute(Name="__NULL__")]
    NULL,

    /// <summary>
    ///   The field value is original, extracted directly from the record. What you see is what you get, including misspellings and other errors in the record.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Original")]
    Original,

    /// <summary>
    ///   The field value is interpreted, meaning a user or other automated process applied some reasoning to interpret the value.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Interpreted")]
    Interpreted,

    /// <summary>
    ///   Custom
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/OTHER")]
    OTHER
  }
}
