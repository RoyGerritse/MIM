#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0")]
[System.Xml.Serialization.XmlRootAttribute("ObjecttypeRef", Namespace="http://www.geostandaarden.nl/mim/mim-ref/1.0", IsNullable=false)]
public class RefType {
    
    private string labelField;
    
    private string indexField;
    
    private string hrefField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string label {
        get => labelField;
        set => labelField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string index {
        get => indexField;
        set => indexField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
    public string href {
        get => hrefField;
        set => hrefField = value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute]
    public string Value {
        get => valueField;
        set => valueField = value;
    }
}