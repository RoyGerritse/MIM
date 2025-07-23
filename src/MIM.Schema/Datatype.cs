#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Referentielijst))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Codelijst))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Enumeratie))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GestructureerdDatatype))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimitiefDatatype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public abstract partial class Datatype {
    
    private DatatypeSupertypen supertypenField;
    
    private string idField;
    
    private string indexField;
    
    /// <remarks/>
    public DatatypeSupertypen supertypen {
        get {
            return this.supertypenField;
        }
        set {
            this.supertypenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string index {
        get {
            return this.indexField;
        }
        set {
            this.indexField = value;
        }
    }
}