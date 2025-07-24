#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public class GeneralisatieDatatypen {
    
    private string datumOpnameField;
    
    private GeneralisatieDatatypenSupertype supertypeField;
    
    private KenmerkenKenmerk[] kenmerkenField;
    
    private string idField;
    
    private string indexField;
    
    /// <remarks/>
    public string datumOpname {
        get => datumOpnameField;
        set => datumOpnameField = value;
    }
    
    /// <remarks/>
    public GeneralisatieDatatypenSupertype supertype {
        get => supertypeField;
        set => supertypeField = value;
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