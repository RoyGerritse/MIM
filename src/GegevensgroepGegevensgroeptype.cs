#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class GegevensgroepGegevensgroeptype {
    
    private RefType gegevensgroeptypeRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0")]
    public RefType GegevensgroeptypeRef {
        get {
            return this.gegevensgroeptypeRefField;
        }
        set {
            this.gegevensgroeptypeRefField = value;
        }
    }
}