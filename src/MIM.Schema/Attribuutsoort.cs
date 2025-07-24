#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public class Attribuutsoort {
    
    private string naamField;
    
    private string[] begripField;
    
    private string aliasField;
    
    private string herkomstField;
    
    private xhtmlText definitieField;
    
    private string herkomstDefinitieField;
    
    private xhtmlText toelichtingField;
    
    private string datumOpnameField;
    
    private AttribuutsoortType typeField;
    
    private string lengteField;
    
    private string patroonField;
    
    private string formeelPatroonField;
    
    private bool indicatieMaterieleHistorieField;
    
    private bool indicatieFormeleHistorieField;
    
    private string kardinaliteitField;
    
    private string authentiekField;
    
    private string locatieField;
    
    private bool indicatieAfleidbaarField;
    
    private bool indicatieClassificerendField;
    
    private bool mogelijkGeenWaardeField;
    
    private bool identificerendField;
    
    private bool identificerendFieldSpecified;
    
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
    public AttribuutsoortType type {
        get => typeField;
        set => typeField = value;
    }
    
    /// <remarks/>
    public string lengte {
        get => lengteField;
        set => lengteField = value;
    }
    
    /// <remarks/>
    public string patroon {
        get => patroonField;
        set => patroonField = value;
    }
    
    /// <remarks/>
    public string formeelPatroon {
        get => formeelPatroonField;
        set => formeelPatroonField = value;
    }
    
    /// <remarks/>
    public bool indicatieMaterieleHistorie {
        get => indicatieMaterieleHistorieField;
        set => indicatieMaterieleHistorieField = value;
    }
    
    /// <remarks/>
    public bool indicatieFormeleHistorie {
        get => indicatieFormeleHistorieField;
        set => indicatieFormeleHistorieField = value;
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
    public string locatie {
        get => locatieField;
        set => locatieField = value;
    }
    
    /// <remarks/>
    public bool indicatieAfleidbaar {
        get => indicatieAfleidbaarField;
        set => indicatieAfleidbaarField = value;
    }
    
    /// <remarks/>
    public bool indicatieClassificerend {
        get => indicatieClassificerendField;
        set => indicatieClassificerendField = value;
    }
    
    /// <remarks/>
    public bool mogelijkGeenWaarde {
        get => mogelijkGeenWaardeField;
        set => mogelijkGeenWaardeField = value;
    }
    
    /// <remarks/>
    public bool identificerend {
        get => identificerendField;
        set => identificerendField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool identificerendSpecified {
        get => identificerendFieldSpecified;
        set => identificerendFieldSpecified = value;
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