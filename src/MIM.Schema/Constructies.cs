#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0", IsNullable=false)]
public partial class Constructies {
    
    private Constructie[] constructieField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Constructie")]
    public Constructie[] Constructie {
        get {
            return this.constructieField;
        }
        set {
            this.constructieField = value;
        }
    }
}