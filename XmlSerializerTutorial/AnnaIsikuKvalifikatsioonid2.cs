﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
[System.Xml.Serialization.XmlRootAttribute("Paring", Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IsNullable=false)]
public partial class AnnaIsikuKvalifikatsioonidParing {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private object[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AsjaNR", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Viitenumber", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IsikuEesnimi", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("IsikuNimi", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("IsikuSynniKP", typeof(System.DateTime), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
    [System.Xml.Serialization.XmlElementAttribute("Isikukood", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute(":AsjaNR")]
    AsjaNR,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute(":Viitenumber")]
    Viitenumber,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute(":IsikuEesnimi")]
    IsikuEesnimi,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute(":IsikuNimi")]
    IsikuNimi,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute(":IsikuSynniKP")]
    IsikuSynniKP,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute(":Isikukood")]
    Isikukood,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class SeaduseSate {
    
    private System.Nullable<System.DateTime> algusKPField;
    
    private System.Nullable<long> jaguNRField;
    
    private System.Nullable<long> jaoNimetusKLField;
    
    private System.Nullable<long> jaotiseNimetusKLField;
    
    private System.Nullable<long> jaotisNRField;
    
    private System.Nullable<long> liikKLField;
    
    private System.Nullable<long> loigeField;
    
    private System.Nullable<long> loigePrimmField;
    
    private System.Nullable<System.DateTime> loppKPField;
    
    private System.Nullable<long> objektIDField;
    
    private System.Nullable<long> paragrahvField;
    
    private System.Nullable<long> paragrahvPrimmField;
    
    private System.Nullable<long> peatykiNimetusKLField;
    
    private System.Nullable<long> peatykkNRField;
    
    private string punktField;
    
    private System.Nullable<long> punktPrimmField;
    
    private System.Nullable<long> seadustikKLField;
    
    private string tekstField;
    
    private string tekstLyhendatultField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> AlgusKP {
        get {
            return this.algusKPField;
        }
        set {
            this.algusKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaguNR {
        get {
            return this.jaguNRField;
        }
        set {
            this.jaguNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaoNimetusKL {
        get {
            return this.jaoNimetusKLField;
        }
        set {
            this.jaoNimetusKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaotiseNimetusKL {
        get {
            return this.jaotiseNimetusKLField;
        }
        set {
            this.jaotiseNimetusKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaotisNR {
        get {
            return this.jaotisNRField;
        }
        set {
            this.jaotisNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> LiikKL {
        get {
            return this.liikKLField;
        }
        set {
            this.liikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> Loige {
        get {
            return this.loigeField;
        }
        set {
            this.loigeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> LoigePrimm {
        get {
            return this.loigePrimmField;
        }
        set {
            this.loigePrimmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> LoppKP {
        get {
            return this.loppKPField;
        }
        set {
            this.loppKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> Paragrahv {
        get {
            return this.paragrahvField;
        }
        set {
            this.paragrahvField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> ParagrahvPrimm {
        get {
            return this.paragrahvPrimmField;
        }
        set {
            this.paragrahvPrimmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> PeatykiNimetusKL {
        get {
            return this.peatykiNimetusKLField;
        }
        set {
            this.peatykiNimetusKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> PeatykkNR {
        get {
            return this.peatykkNRField;
        }
        set {
            this.peatykkNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string Punkt {
        get {
            return this.punktField;
        }
        set {
            this.punktField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> PunktPrimm {
        get {
            return this.punktPrimmField;
        }
        set {
            this.punktPrimmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> SeadustikKL {
        get {
            return this.seadustikKLField;
        }
        set {
            this.seadustikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string Tekst {
        get {
            return this.tekstField;
        }
        set {
            this.tekstField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string TekstLyhendatult {
        get {
            return this.tekstLyhendatultField;
        }
        set {
            this.tekstLyhendatultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class SyydistusPunkt {
    
    private System.Nullable<System.DateTime> algusKPField;
    
    private string klientsysteemiIDField;
    
    private System.Nullable<System.DateTime> lahendiKPField;
    
    private System.Nullable<long> lahendKLField;
    
    private System.Nullable<System.DateTime> loppKPField;
    
    private System.Nullable<long> objektIDField;
    
    private System.Nullable<System.DateTime> sulgemiseKPField;
    
    private string syydistusPunktCSVField;
    
    private KvalifikatsiooniParagrahv[] kvalifikatsiooniParagrahvidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> AlgusKP {
        get {
            return this.algusKPField;
        }
        set {
            this.algusKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string KlientsysteemiID {
        get {
            return this.klientsysteemiIDField;
        }
        set {
            this.klientsysteemiIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> LahendiKP {
        get {
            return this.lahendiKPField;
        }
        set {
            this.lahendiKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> LahendKL {
        get {
            return this.lahendKLField;
        }
        set {
            this.lahendKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> LoppKP {
        get {
            return this.loppKPField;
        }
        set {
            this.loppKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<System.DateTime> SulgemiseKP {
        get {
            return this.sulgemiseKPField;
        }
        set {
            this.sulgemiseKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string SyydistusPunktCSV {
        get {
            return this.syydistusPunktCSVField;
        }
        set {
            this.syydistusPunktCSVField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public KvalifikatsiooniParagrahv[] KvalifikatsiooniParagrahvid {
        get {
            return this.kvalifikatsiooniParagrahvidField;
        }
        set {
            this.kvalifikatsiooniParagrahvidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class KvalifikatsiooniParagrahv {
    
    private System.Nullable<System.DateTime> algusKPField;
    
    private System.Nullable<long> jaguNRField;
    
    private System.Nullable<long> jaoNimetusKLField;
    
    private System.Nullable<long> jaotiseNimetusKLField;
    
    private System.Nullable<long> jaotisNRField;
    
    private System.Nullable<long> liikKLField;
    
    private System.Nullable<long> loigeField;
    
    private System.Nullable<long> loigePrimmField;
    
    private System.Nullable<System.DateTime> loppKPField;
    
    private System.Nullable<long> objektIDField;
    
    private System.Nullable<long> paragrahvField;
    
    private System.Nullable<long> paragrahvPrimmField;
    
    private System.Nullable<long> peatykiNimetusKLField;
    
    private System.Nullable<long> peatykkNRField;
    
    private string punktField;
    
    private System.Nullable<long> punktPrimmField;
    
    private System.Nullable<long> seadustikKLField;
    
    private string tekstField;
    
    private string tekstLyhendatultField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> AlgusKP {
        get {
            return this.algusKPField;
        }
        set {
            this.algusKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaguNR {
        get {
            return this.jaguNRField;
        }
        set {
            this.jaguNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaoNimetusKL {
        get {
            return this.jaoNimetusKLField;
        }
        set {
            this.jaoNimetusKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaotiseNimetusKL {
        get {
            return this.jaotiseNimetusKLField;
        }
        set {
            this.jaotiseNimetusKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> JaotisNR {
        get {
            return this.jaotisNRField;
        }
        set {
            this.jaotisNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> LiikKL {
        get {
            return this.liikKLField;
        }
        set {
            this.liikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> Loige {
        get {
            return this.loigeField;
        }
        set {
            this.loigeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> LoigePrimm {
        get {
            return this.loigePrimmField;
        }
        set {
            this.loigePrimmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", IsNullable=true)]
    public System.Nullable<System.DateTime> LoppKP {
        get {
            return this.loppKPField;
        }
        set {
            this.loppKPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> Paragrahv {
        get {
            return this.paragrahvField;
        }
        set {
            this.paragrahvField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> ParagrahvPrimm {
        get {
            return this.paragrahvPrimmField;
        }
        set {
            this.paragrahvPrimmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> PeatykiNimetusKL {
        get {
            return this.peatykiNimetusKLField;
        }
        set {
            this.peatykiNimetusKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> PeatykkNR {
        get {
            return this.peatykkNRField;
        }
        set {
            this.peatykkNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string Punkt {
        get {
            return this.punktField;
        }
        set {
            this.punktField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> PunktPrimm {
        get {
            return this.punktPrimmField;
        }
        set {
            this.punktPrimmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> SeadustikKL {
        get {
            return this.seadustikKLField;
        }
        set {
            this.seadustikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string Tekst {
        get {
            return this.tekstField;
        }
        set {
            this.tekstField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string TekstLyhendatult {
        get {
            return this.tekstLyhendatultField;
        }
        set {
            this.tekstLyhendatultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class Sanktsioon {
    
    private long objektIDField;
    
    private System.Nullable<long> alaLiikKLField;
    
    private long liikKLField;
    
    private long tyypKLField;
    
    private object[] aluseksOlevadSyydistusPunktidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> AlaLiikKL {
        get {
            return this.alaLiikKLField;
        }
        set {
            this.alaLiikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long LiikKL {
        get {
            return this.liikKLField;
        }
        set {
            this.liikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long TyypKL {
        get {
            return this.tyypKLField;
        }
        set {
            this.tyypKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SyydistusPunkt", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public object[] AluseksOlevadSyydistusPunktid {
        get {
            return this.aluseksOlevadSyydistusPunktidField;
        }
        set {
            this.aluseksOlevadSyydistusPunktidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class FyysilineIsik {
    
    private string eesnimiField;
    
    private string nimiField;
    
    private string koodField;
    
    private string muudeRiikideKoodidField;
    
    private long objektIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Eesnimi {
        get {
            return this.eesnimiField;
        }
        set {
            this.eesnimiField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Nimi {
        get {
            return this.nimiField;
        }
        set {
            this.nimiField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string Kood {
        get {
            return this.koodField;
        }
        set {
            this.koodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string MuudeRiikideKoodid {
        get {
            return this.muudeRiikideKoodidField;
        }
        set {
            this.muudeRiikideKoodidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class ToiminguOsaline {
    
    private FyysilineIsik fyysilineIsikField;
    
    private Sanktsioon[] sanktsioonidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public FyysilineIsik FyysilineIsik {
        get {
            return this.fyysilineIsikField;
        }
        set {
            this.fyysilineIsikField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Sanktsioon[] Sanktsioonid {
        get {
            return this.sanktsioonidField;
        }
        set {
            this.sanktsioonidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class Toiming {
    
    private System.Nullable<long> alaLiikKLField;
    
    private long liikKLField;
    
    private long objektIDField;
    
    private ToiminguOsaline[] toiminguOsalisedField;
    
    private SeaduseSate[] alusedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> AlaLiikKL {
        get {
            return this.alaLiikKLField;
        }
        set {
            this.alaLiikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long LiikKL {
        get {
            return this.liikKLField;
        }
        set {
            this.liikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public ToiminguOsaline[] ToiminguOsalised {
        get {
            return this.toiminguOsalisedField;
        }
        set {
            this.toiminguOsalisedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public SeaduseSate[] Alused {
        get {
            return this.alusedField;
        }
        set {
            this.alusedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
public partial class Menetlus {
    
    private string menetluseNRField;
    
    private long objektIDField;
    
    private Toiming[] toimingudField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string MenetluseNR {
        get {
            return this.menetluseNRField;
        }
        set {
            this.menetluseNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Toiming[] Toimingud {
        get {
            return this.toimingudField;
        }
        set {
            this.toimingudField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid")]
[System.Xml.Serialization.XmlRootAttribute("Vastus", Namespace="http://producer.etoimik.xtee.riik.ee/producer/etoimik/AnnaIsikuKvalifikatsioonid", IsNullable=true)]
public partial class AnnaIsikuKvalifikatsioonidVastus {
    
    private string asjaNRField;
    
    private System.Nullable<long> liikKLField;
    
    private long objektIDField;
    
    private Menetlus[] menetlusedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string AsjaNR {
        get {
            return this.asjaNRField;
        }
        set {
            this.asjaNRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> LiikKL {
        get {
            return this.liikKLField;
        }
        set {
            this.liikKLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long ObjektID {
        get {
            return this.objektIDField;
        }
        set {
            this.objektIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Menetlus[] Menetlused {
        get {
            return this.menetlusedField;
        }
        set {
            this.menetlusedField = value;
        }
    }
}
