#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public partial class Relatieklasse {
    
    private string naamField;
    
    private string[] begripField;
    
    private string aliasField;
    
    private string herkomstField;
    
    private xhtmlText definitieField;
    
    private string herkomstDefinitieField;
    
    private xhtmlText toelichtingField;
    
    private string datumOpnameField;
    
    private bool indicatieMaterieleHistorieField;
    
    private bool indicatieMaterieleHistorieFieldSpecified;
    
    private bool indicatieFormeleHistorieField;
    
    private bool indicatieFormeleHistorieFieldSpecified;
    
    private string kardinaliteitField;
    
    private string authentiekField;
    
    private bool indicatieAfleidbaarField;
    
    private bool mogelijkGeenWaardeField;
    
    private RelatieklasseAggregatietype aggregatietypeField;
    
    private Attribuutsoort[] attribuutsoortenField;
    
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
    public bool indicatieMaterieleHistorie {
        get {
            return this.indicatieMaterieleHistorieField;
        }
        set {
            this.indicatieMaterieleHistorieField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool indicatieMaterieleHistorieSpecified {
        get {
            return this.indicatieMaterieleHistorieFieldSpecified;
        }
        set {
            this.indicatieMaterieleHistorieFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool indicatieFormeleHistorie {
        get {
            return this.indicatieFormeleHistorieField;
        }
        set {
            this.indicatieFormeleHistorieField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool indicatieFormeleHistorieSpecified {
        get {
            return this.indicatieFormeleHistorieFieldSpecified;
        }
        set {
            this.indicatieFormeleHistorieFieldSpecified = value;
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
    public string authentiek {
        get {
            return this.authentiekField;
        }
        set {
            this.authentiekField = value;
        }
    }
    
    /// <remarks/>
    public bool indicatieAfleidbaar {
        get {
            return this.indicatieAfleidbaarField;
        }
        set {
            this.indicatieAfleidbaarField = value;
        }
    }
    
    /// <remarks/>
    public bool mogelijkGeenWaarde {
        get {
            return this.mogelijkGeenWaardeField;
        }
        set {
            this.mogelijkGeenWaardeField = value;
        }
    }
    
    /// <remarks/>
    public RelatieklasseAggregatietype aggregatietype {
        get {
            return this.aggregatietypeField;
        }
        set {
            this.aggregatietypeField = value;
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