#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public class Informatiemodel {
    
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
        get => naamField;
        set => naamField = value;
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
    public string informatiemodeltype {
        get => informatiemodeltypeField;
        set => informatiemodeltypeField = value;
    }
    
    /// <remarks/>
    public string informatiedomein {
        get => informatiedomeinField;
        set => informatiedomeinField = value;
    }
    
    /// <remarks/>
    public Relatiemodelleringtype relatiemodelleringtype {
        get => relatiemodelleringtypeField;
        set => relatiemodelleringtypeField = value;
    }
    
    /// <remarks/>
    public InformatiemodelMIMVersie MIMVersie {
        get => mIMVersieField;
        set => mIMVersieField = value;
    }
    
    /// <remarks/>
    public string MIMExtensie {
        get => mIMExtensieField;
        set => mIMExtensieField = value;
    }
    
    /// <remarks/>
    public string MIMExtensieVersie {
        get => mIMExtensieVersieField;
        set => mIMExtensieVersieField = value;
    }
    
    /// <remarks/>
    public string MIMTaal {
        get => mIMTaalField;
        set => mIMTaalField = value;
    }
    
    /// <remarks/>
    public InformatiemodelPackages packages {
        get => packagesField;
        set => packagesField = value;
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