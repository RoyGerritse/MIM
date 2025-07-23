#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public partial class Constraints {
    
    private Constraint[] constraintField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Constraint")]
    public Constraint[] Constraint {
        get {
            return this.constraintField;
        }
        set {
            this.constraintField = value;
        }
    }
}