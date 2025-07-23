#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class DomeinViewDatatypen {
    
    private Datatype[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Codelijst", typeof(Codelijst))]
    [System.Xml.Serialization.XmlElementAttribute("Enumeratie", typeof(Enumeratie))]
    [System.Xml.Serialization.XmlElementAttribute("GestructureerdDatatype", typeof(GestructureerdDatatype))]
    [System.Xml.Serialization.XmlElementAttribute("PrimitiefDatatype", typeof(PrimitiefDatatype))]
    [System.Xml.Serialization.XmlElementAttribute("Referentielijst", typeof(Referentielijst))]
    public Datatype[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}