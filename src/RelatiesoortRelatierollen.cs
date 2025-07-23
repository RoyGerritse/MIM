#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class RelatiesoortRelatierollen {
    
    private Relatierol bronField;
    
    private Relatierol doelField;
    
    /// <remarks/>
    public Relatierol Bron {
        get {
            return this.bronField;
        }
        set {
            this.bronField = value;
        }
    }
    
    /// <remarks/>
    public Relatierol Doel {
        get {
            return this.doelField;
        }
        set {
            this.doelField = value;
        }
    }
}