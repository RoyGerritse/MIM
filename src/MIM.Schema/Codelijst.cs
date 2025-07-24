#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public class Codelijst : Datatype {
    
    private string naamField;
    
    private string[] begripField;
    
    private string aliasField;
    
    private string herkomstField;
    
    private xhtmlText definitieField;
    
    private string herkomstDefinitieField;
    
    private xhtmlText toelichtingField;
    
    private string datumOpnameField;
    
    private string locatieField;
    
    private KenmerkenKenmerk[] kenmerkenField;
    
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
    public string locatie {
        get => locatieField;
        set => locatieField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ext/1.0")]
    [System.Xml.Serialization.XmlArrayItemAttribute("Kenmerk", IsNullable=false)]
    public KenmerkenKenmerk[] kenmerken {
        get => kenmerkenField;
        set => kenmerkenField = value;
    }
}