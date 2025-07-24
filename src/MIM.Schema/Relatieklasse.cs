#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public class Relatieklasse {
    
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
        get => naamField;
        set => naamField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("begrip")]
    public string[] begrip {
        get => begripField;
        set => begripField = value;
    }
    
    /// <remarks/>
    public string alias {
        get => aliasField;
        set => aliasField = value;
    }
    
    /// <remarks/>
    public string herkomst {
        get => herkomstField;
        set => herkomstField = value;
    }
    
    /// <remarks/>
    public xhtmlText definitie {
        get => definitieField;
        set => definitieField = value;
    }
    
    /// <remarks/>
    public string herkomstDefinitie {
        get => herkomstDefinitieField;
        set => herkomstDefinitieField = value;
    }
    
    /// <remarks/>
    public xhtmlText toelichting {
        get => toelichtingField;
        set => toelichtingField = value;
    }
    
    /// <remarks/>
    public string datumOpname {
        get => datumOpnameField;
        set => datumOpnameField = value;
    }
    
    /// <remarks/>
    public bool indicatieMaterieleHistorie {
        get => indicatieMaterieleHistorieField;
        set => indicatieMaterieleHistorieField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool indicatieMaterieleHistorieSpecified {
        get => indicatieMaterieleHistorieFieldSpecified;
        set => indicatieMaterieleHistorieFieldSpecified = value;
    }
    
    /// <remarks/>
    public bool indicatieFormeleHistorie {
        get => indicatieFormeleHistorieField;
        set => indicatieFormeleHistorieField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool indicatieFormeleHistorieSpecified {
        get => indicatieFormeleHistorieFieldSpecified;
        set => indicatieFormeleHistorieFieldSpecified = value;
    }
    
    /// <remarks/>
    public string kardinaliteit {
        get => kardinaliteitField;
        set => kardinaliteitField = value;
    }
    
    /// <remarks/>
    public string authentiek {
        get => authentiekField;
        set => authentiekField = value;
    }
    
    /// <remarks/>
    public bool indicatieAfleidbaar {
        get => indicatieAfleidbaarField;
        set => indicatieAfleidbaarField = value;
    }
    
    /// <remarks/>
    public bool mogelijkGeenWaarde {
        get => mogelijkGeenWaardeField;
        set => mogelijkGeenWaardeField = value;
    }
    
    /// <remarks/>
    public RelatieklasseAggregatietype aggregatietype {
        get => aggregatietypeField;
        set => aggregatietypeField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Attribuutsoort[] attribuutsoorten {
        get => attribuutsoortenField;
        set => attribuutsoortenField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public Constraint[] constraints {
        get => constraintsField;
        set => constraintsField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
    [System.Xml.Serialization.XmlArrayItemAttribute("Kenmerk", IsNullable=false)]
    public KenmerkenKenmerk[] kenmerken {
        get => kenmerkenField;
        set => kenmerkenField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string id {
        get => idField;
        set => idField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string index {
        get => indexField;
        set => indexField = value;
    }
}