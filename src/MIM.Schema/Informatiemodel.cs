#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public partial class Informatiemodel {
    
    private string naamField;
    
    private string aliasField;
    
    private string herkomstField;
    
    private xhtmlText definitieField;
    
    private string herkomstDefinitieField;
    
    private xhtmlText toelichtingField;
    
    private string datumOpnameField;
    
    private string informatiemodeltypeField;
    
    private string informatiedomeinField;
    
    private Relatiemodelleringtype relatiemodelleringtypeField;
    
    private InformatiemodelMIMVersie mIMVersieField;
    
    private string mIMExtensieField;
    
    private string mIMExtensieVersieField;
    
    private string mIMTaalField;
    
    private InformatiemodelPackages packagesField;
    
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
    public string informatiemodeltype {
        get {
            return this.informatiemodeltypeField;
        }
        set {
            this.informatiemodeltypeField = value;
        }
    }
    
    /// <remarks/>
    public string informatiedomein {
        get {
            return this.informatiedomeinField;
        }
        set {
            this.informatiedomeinField = value;
        }
    }
    
    /// <remarks/>
    public Relatiemodelleringtype relatiemodelleringtype {
        get {
            return this.relatiemodelleringtypeField;
        }
        set {
            this.relatiemodelleringtypeField = value;
        }
    }
    
    /// <remarks/>
    public InformatiemodelMIMVersie MIMVersie {
        get {
            return this.mIMVersieField;
        }
        set {
            this.mIMVersieField = value;
        }
    }
    
    /// <remarks/>
    public string MIMExtensie {
        get {
            return this.mIMExtensieField;
        }
        set {
            this.mIMExtensieField = value;
        }
    }
    
    /// <remarks/>
    public string MIMExtensieVersie {
        get {
            return this.mIMExtensieVersieField;
        }
        set {
            this.mIMExtensieVersieField = value;
        }
    }
    
    /// <remarks/>
    public string MIMTaal {
        get {
            return this.mIMTaalField;
        }
        set {
            this.mIMTaalField = value;
        }
    }
    
    /// <remarks/>
    public InformatiemodelPackages packages {
        get {
            return this.packagesField;
        }
        set {
            this.packagesField = value;
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