#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Datatype,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.geostandaarden.nl/mim/mim-ext/1.0:ConstructieRef")]
    ConstructieRef,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.geostandaarden.nl/mim/mim-ref/1.0:DatatypeRef")]
    DatatypeRef,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("http://www.geostandaarden.nl/mim/mim-ref/1.0:KeuzeRef")]
    KeuzeRef,
}