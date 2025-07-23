#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0", IsNullable=false)]
public partial class Kenmerken {
    
    private KenmerkenKenmerk[] kenmerkField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Kenmerk")]
    public KenmerkenKenmerk[] Kenmerk {
        get {
            return this.kenmerkField;
        }
        set {
            this.kenmerkField = value;
        }
    }
}