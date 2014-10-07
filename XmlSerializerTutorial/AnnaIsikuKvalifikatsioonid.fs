namespace XmlSerializerTutorial.AnnaIsikuKvalifikatsioonid

open System
open System.CodeDom.Compiler
open System.ComponentModel
open System.Diagnostics
open System.Xml.Serialization
open System.Xml.Schema

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<XmlType(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IncludeInSchema=false)>]
type ItemChoiceType =
    | [<XmlEnum(":AsjaNR")>] AsjaNR = 0
    | [<XmlEnum(":Viitenumber")>] Viitenumber = 1

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<XmlType(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IncludeInSchema=false)>]
type ItemsChoiceType =
    | [<XmlEnum(":IsikuEesnimi")>] IsikuEesnimi = 0
    | [<XmlEnum(":IsikuNimi")>] IsikuNimi = 1
    | [<XmlEnum(":IsikuSynniKP")>] IsikuSynniKP = 2
    | [<XmlEnum(":Isikukood")>] Isikukood = 3

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
[<XmlRoot("Paring", Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IsNullable=false)>]
type AnnaIsikuKvalifikatsioonidParing () =
    [<XmlElement("AsjaNR", typeof<string>, Form=XmlSchemaForm.Unqualified)>]
    [<XmlElement("Viitenumber", typeof<string>, Form=XmlSchemaForm.Unqualified)>]
    [<XmlChoiceIdentifier("ItemElementName")>]
    member val Item = Unchecked.defaultof<string> with get, set
    [<XmlIgnore>]
    member val ItemElementName = Unchecked.defaultof<ItemChoiceType> with get, set
    [<XmlElement("IsikuEesnimi", typeof<string>, Form=XmlSchemaForm.Unqualified)>]
    [<XmlElement("IsikuNimi", typeof<string>, Form=XmlSchemaForm.Unqualified)>]
    [<XmlElement("IsikuSynniKP", typeof<DateTime>, Form=XmlSchemaForm.Unqualified, DataType="date")>]
    [<XmlElement("Isikukood", typeof<string>, Form=XmlSchemaForm.Unqualified)>]
    [<XmlChoiceIdentifier("ItemsElementName")>]
    member val Items = Unchecked.defaultof<obj[]> with get, set
    /// <remarks/>
    [<XmlElement("ItemsElementName")>]
    [<XmlIgnore>]
    member val ItemsElementName = Unchecked.defaultof<ItemsChoiceType[]> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineFyysilineIsik () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val Eesnimi = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val Nimi = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Kood = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val MuudeRiikideKoodid = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val ObjektID = 0L with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineSanktsioonSyydistusPunktKvalifikatsiooniParagrahv () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val AlgusKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaguNR = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaoNimetusKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaotiseNimetusKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaotisNR = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val LiikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Loige = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val LoigePrimm = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val LoppKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val ObjektID = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Paragrahv = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val ParagrahvPrimm = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val PeatykiNimetusKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val PeatykkNR = Unchecked.defaultof<Nullable<int64>>
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Punkt = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val PunktPrimm = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val SeadustikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Tekst = Unchecked.defaultof<string> with get, set
    [<XmlElementAttribute(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val TekstLyhendatult = Unchecked.defaultof<string> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineSanktsioonSyydistusPunkt () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val AlgusKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val KlientsysteemiID = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val LahendiKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val LahendKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val LoppKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val ObjektID = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val SulgemiseKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val SyydistusPunktCSV = Unchecked.defaultof<string> with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("KvalifikatsiooniParagrahv", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val KvalifikatsiooniParagrahvid = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineSanktsioonSyydistusPunktKvalifikatsiooniParagrahv[]> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineSanktsioon () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val ObjektID = 0L with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val AlaLiikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val LiikKL = 0L with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val TyypKL = 0L with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("SyydistusPunkt", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val AluseksOlevadSyydistusPunktid = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineSanktsioonSyydistusPunkt[]>

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsaline () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val FyysilineIsik = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineFyysilineIsik> with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("Sanktsioon", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val Sanktsioonid = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsalineSanktsioon[]> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingSeaduseSate () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val AlgusKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaguNR = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaoNimetusKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaotiseNimetusKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val JaotisNR = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val LiikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Loige = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val LoigePrimm = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)>]
    member val LoppKP = Unchecked.defaultof<Nullable<DateTime>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val ObjektID = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Paragrahv = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val ParagrahvPrimm = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val PeatykiNimetusKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val PeatykkNR = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Punkt = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val PunktPrimm = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val SeadustikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Tekst = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val TekstLyhendatult = Unchecked.defaultof<string> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToiming () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val AlaLiikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val LiikKL = 0L with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val ObjektID = 0L with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("ToiminguOsaline", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val ToiminguOsalised = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingToiminguOsaline[]> with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("SeaduseSate", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val Alused = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToimingSeaduseSate[]> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsiMenetlus () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val MenetluseNR = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val ObjektID = 0L with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("Toiming", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val Toimingud = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlusToiming[]> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(AnonymousType=true, Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
type AnnaIsikuKvalifikatsioonidVastusAsi () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val AsjaNR = Unchecked.defaultof<string> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val LiikKL = Unchecked.defaultof<Nullable<int64>> with get, set
    [<XmlElement(Form=XmlSchemaForm.Unqualified)>]
    member val ObjektID = 0L with get, set
    [<XmlArray(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    [<XmlArrayItem("Menetlus", Form=XmlSchemaForm.Unqualified, IsNullable=false)>]
    member val Menetlused = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsiMenetlus[]> with get, set

[<GeneratedCode("xsd", "4.0.30319.17929")>]
[<Serializable>]
[<DebuggerStepThrough>]
[<DesignerCategory("code")>]
[<XmlType(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")>]
[<XmlRoot("Vastus", Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IsNullable=false)>]
type AnnaIsikuKvalifikatsioonidVastus () =
    [<XmlElement(Form=XmlSchemaForm.Unqualified, IsNullable=true)>]
    member val Asi = Unchecked.defaultof<AnnaIsikuKvalifikatsioonidVastusAsi> with get, set
