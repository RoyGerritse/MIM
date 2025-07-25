﻿#nullable disable
namespace MIM.Schema;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9032.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1")]
[System.Xml.Serialization.XmlRootAttribute("Datatype", Namespace="http://www.geostandaarden.nl/mim/mim-core/1.1", IsNullable=false)]
public class Datatype1 {
    
    private string labelField;
    
    private string indexField;
    
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
    [System.Xml.Serialization.XmlTextAttribute]
    public string Value {
        get => valueField;
        set => valueField = value;
    }
}