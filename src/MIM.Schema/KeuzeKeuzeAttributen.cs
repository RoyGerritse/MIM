#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
public class KeuzeKeuzeAttributen {
    
    private Attribuutsoort[] attribuutsoortField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Attribuutsoort")]
    public Attribuutsoort[] Attribuutsoort {
        get => attribuutsoortField;
        set => attribuutsoortField = value;
    }
}