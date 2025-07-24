#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public class AttribuutsoortType {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Datatype", typeof(Datatype1))]
    [System.Xml.Serialization.XmlElementAttribute("ConstructieRef", typeof(RefType1), Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
    [System.Xml.Serialization.XmlElementAttribute("DatatypeRef", typeof(RefType), Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0")]
    [System.Xml.Serialization.XmlElementAttribute("KeuzeRef", typeof(RefType), Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
        get => itemField;
        set => itemField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemChoiceType ItemElementName {
        get => itemElementNameField;
        set => itemElementNameField = value;
    }
}