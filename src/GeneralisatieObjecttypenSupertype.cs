#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class GeneralisatieObjecttypenSupertype {
    
    private RefType objecttypeRefField;
    
    private RefType1[] constructieRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0")]
    public RefType ObjecttypeRef {
        get {
            return this.objecttypeRefField;
        }
        set {
            this.objecttypeRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConstructieRef", Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
    public RefType1[] ConstructieRef {
        get {
            return this.constructieRefField;
        }
        set {
            this.constructieRefField = value;
        }
    }
}