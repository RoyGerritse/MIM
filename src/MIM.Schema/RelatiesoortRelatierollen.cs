#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public class RelatiesoortRelatierollen {
    
    private Relatierol bronField;
    
    private Relatierol doelField;
    
    /// <remarks/>
    public Relatierol Bron {
        get => bronField;
        set => bronField = value;
    }
    
    /// <remarks/>
    public Relatierol Doel {
        get => doelField;
        set => doelField = value;
    }
}