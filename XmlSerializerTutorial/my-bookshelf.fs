namespace XmlSerializerTutorial.MyBookshelf

open System
open System.CodeDom.Compiler
open System.ComponentModel
open System.Diagnostics
open System.Xml.Serialization

[<XmlInclude(typeof<bookType_1>)>]
[<GeneratedCodeAttribute("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(Namespace="urn:xmlns:25hoursaday-com:my-bookshelf")>]
type bookType () =
    member val title = Unchecked.defaultof<string> with get, set
    member val author = Unchecked.defaultof<string> with get, set

    [<XmlElement("publication-date", DataType="date")>]
    member val publicationdate = Unchecked.defaultof<Nullable<DateTime>> with get, set

    [<XmlAttribute>]
    member val publisher = Unchecked.defaultof<string> with get, set

    [<XmlAttribute("on-loan")>]
    member val onloan = Unchecked.defaultof<string> with get, set
and bookType_1 () = inherit bookType()

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="urn:xmlns:25hoursaday-com:my-bookshelf")>]
[<XmlRoot(Namespace="urn:xmlns:25hoursaday-com:my-bookshelf", IsNullable=false)>]
type books () =
    [<XmlElement("book")>]
    member val book = Unchecked.defaultof<bookType_1[]> with get, set
