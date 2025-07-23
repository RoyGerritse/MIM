#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public partial class DataElement {
    
    private string naamField;
    
    private string[] begripField;
    
    private string aliasField;
    
    private string herkomstField;
    
    private xhtmlText definitieField;
    
    private string herkomstDefinitieField;
    
    private xhtmlText toelichtingField;
    
    private string datumOpnameField;
    
    private DataElementType typeField;
    
    private string lengteField;
    
    private string patroonField;
    
    private string formeelPatroonField;
    
    private string kardinaliteitField;
    
    private KenmerkenKenmerk[] kenmerkenField;
    
    private string idField;
    
    private string indexField;
    
    /// <remarks/>
    public string naam {
        get {
            return this.naamField;
        }
        set {
            this.naamField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("begrip")]
    public string[] begrip {
        get {
            return this.begripField;
        }
        set {
            this.begripField = value;
        }
    }
    
    /// <remarks/>
    public string alias {
        get {
            return this.aliasField;
        }
        set {
            this.aliasField = value;
        }
    }
    
    /// <remarks/>
    public string herkomst {
        get {
            return this.herkomstField;
        }
        set {
            this.herkomstField = value;
        }
    }
    
    /// <remarks/>
    public xhtmlText definitie {
        get {
            return this.definitieField;
        }
        set {
            this.definitieField = value;
        }
    }
    
    /// <remarks/>
    public string herkomstDefinitie {
        get {
            return this.herkomstDefinitieField;
        }
        set {
            this.herkomstDefinitieField = value;
        }
    }
    
    /// <remarks/>
    public xhtmlText toelichting {
        get {
            return this.toelichtingField;
        }
        set {
            this.toelichtingField = value;
        }
    }
    
    /// <remarks/>
    public string datumOpname {
        get {
            return this.datumOpnameField;
        }
        set {
            this.datumOpnameField = value;
        }
    }
    
    /// <remarks/>
    public DataElementType type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    public string lengte {
        get {
            return this.lengteField;
        }
        set {
            this.lengteField = value;
        }
    }
    
    /// <remarks/>
    public string patroon {
        get {
            return this.patroonField;
        }
        set {
            this.patroonField = value;
        }
    }
    
    /// <remarks/>
    public string formeelPatroon {
        get {
            return this.formeelPatroonField;
        }
        set {
            this.formeelPatroonField = value;
        }
    }
    
    /// <remarks/>
    public string kardinaliteit {
        get {
            return this.kardinaliteitField;
        }
        set {
            this.kardinaliteitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
    [System.Xml.Serialization.XmlArrayItemAttribute("Kenmerk", IsNullable=false)]
    public KenmerkenKenmerk[] kenmerken {
        get {
            return this.kenmerkenField;
        }
        set {
            this.kenmerkenField = value;
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