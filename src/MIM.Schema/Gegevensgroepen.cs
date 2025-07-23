#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public partial class Gegevensgroepen {
    
    private Gegevensgroep[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Gegevensgroep")]
    public Gegevensgroep[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}