#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public partial class InformatiemodelPackages {
    
    private Domein[] domeinField;
    
    private View[] viewField;
    
    private Extern[] externField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Domein")]
    public Domein[] Domein {
        get {
            return this.domeinField;
        }
        set {
            this.domeinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("View")]
    public View[] View {
        get {
            return this.viewField;
        }
        set {
            this.viewField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Extern")]
    public Extern[] Extern {
        get {
            return this.externField;
        }
        set {
            this.externField = value;
        }
    }
}