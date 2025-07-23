#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public partial class Objecttype {
    
    private string naamField;
    
    private string[] begripField;
    
    private string aliasField;
    
    private string herkomstField;
    
    private xhtmlText definitieField;
    
    private string herkomstDefinitieField;
    
    private xhtmlText toelichtingField;
    
    private string datumOpnameField;
    
    private string populatieField;
    
    private string kwaliteitField;
    
    private bool indicatieAbstractObjectField;
    
    private GeneralisatieObjecttypen[] supertypenField;
    
    private Attribuutsoort[] attribuutsoortenField;
    
    private Gegevensgroep[] gegevensgroepenField;
    
    private Relatiesoort[] relatiesoortenField;
    
    private ExterneKoppeling[] externeKoppelingenField;
    
    private RefType[] keuzenField;
    
    private Constraint[] constraintsField;
    
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
    public string populatie {
        get {
            return this.populatieField;
        }
        set {
            this.populatieField = value;
        }
    }
    
    /// <remarks/>
    public string kwaliteit {
        get {
            return this.kwaliteitField;
        }
        set {
            this.kwaliteitField = value;
        }
    }
    
    /// <remarks/>
    public bool indicatieAbstractObject {
        get {
            return this.indicatieAbstractObjectField;
        }
        set {
            this.indicatieAbstractObjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public GeneralisatieObjecttypen[] supertypen {
        get {
            return this.supertypenField;
        }
        set {
            this.supertypenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Attribuutsoort[] attribuutsoorten {
        get {
            return this.attribuutsoortenField;
        }
        set {
            this.attribuutsoortenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Gegevensgroep[] gegevensgroepen {
        get {
            return this.gegevensgroepenField;
        }
        set {
            this.gegevensgroepenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Relatiesoort[] relatiesoorten {
        get {
            return this.relatiesoortenField;
        }
        set {
            this.relatiesoortenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public ExterneKoppeling[] externeKoppelingen {
        get {
            return this.externeKoppelingenField;
        }
        set {
            this.externeKoppelingenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("KeuzeRef", Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0", IsNullable=false)]
    public RefType[] keuzen {
        get {
            return this.keuzenField;
        }
        set {
            this.keuzenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Constraint[] constraints {
        get {
            return this.constraintsField;
        }
        set {
            this.constraintsField = value;
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