#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class RelatiesoortRelatieklasse {
    
    private Relatieklasse relatieklasseField;
    
    /// <remarks/>
    public Relatieklasse Relatieklasse {
        get {
            return this.relatieklasseField;
        }
        set {
            this.relatieklasseField = value;
        }
    }
}