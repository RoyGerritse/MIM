#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
public class KenmerkenKenmerk {
    
    private string naamField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string naam {
        get => naamField;
        set => naamField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute]
    public string Value {
        get => valueField;
        set => valueField = value;
    }
}