#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class KeuzeKeuzeRelatiedoelen {
    
    private KeuzeKeuzeRelatiedoelenRelatiedoel[] relatiedoelField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Relatiedoel")]
    public KeuzeKeuzeRelatiedoelenRelatiedoel[] Relatiedoel {
        get {
            return this.relatiedoelField;
        }
        set {
            this.relatiedoelField = value;
        }
    }
}