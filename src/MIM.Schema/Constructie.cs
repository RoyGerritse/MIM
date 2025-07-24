#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0", IsNullable=false)]
public class Constructie {
    
    private string constructietypeField;
    
    private System.Xml.XmlElement[] anyField;
    
    private string idField;
    
    private string indexField;
    
    /// <remarks/>
    public string constructietype {
        get => constructietypeField;
        set => constructietypeField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute]
    public System.Xml.XmlElement[] Any {
        get => anyField;
        set => anyField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string id {
        get => idField;
        set => idField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string index {
        get => indexField;
        set => indexField = value;
    }
}