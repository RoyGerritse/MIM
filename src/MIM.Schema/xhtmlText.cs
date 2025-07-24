#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public class xhtmlText {
    
    private System.Xml.XmlNode[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute]
    [System.Xml.Serialization.XmlAnyElementAttribute]
    public System.Xml.XmlNode[] Any {
        get => anyField;
        set => anyField = value;
    }
}