using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MIM.Schema.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var informatieModel = new Informatiemodel
        {
            naam = "Fietsenwinkel",
            herkomst = "Winkel",
            herkomstDefinitie = "Winkel",
            informatiemodeltype = "Logisch",
            informatiedomein = "informatiedomein",
            relatiemodelleringtype = Relatiemodelleringtype.Relatierolleidend,
            MIMVersie = InformatiemodelMIMVersie.Item111,
            id = "KOR",
            MIMTaal = "NL",
            packages = new InformatiemodelPackages
            {
                
            },
            kenmerken = [new KenmerkenKenmerk
            {
                naam = "Afkorting",
                Value = "IMFW"
            }]
        };
        
        
        var serializer = new XmlSerializer(typeof(Informatiemodel));
        var ns = new XmlSerializerNamespaces();
        ns.Add("cs", "http://www.imvertor.org/metamodels/conceptualschemas/model/v20181210");
        ns.Add("dlogger", "http://www.armatiek.nl/functions/dlogger-proxy");
        ns.Add("mim", "http://www.geostandaarden.nl/mim/mim-core/1.1");
        ns.Add("mim-ext", "http://www.geostandaarden.nl/mim/mim-ext/1.0");
        ns.Add("mim-ref", "http://www.geostandaarden.nl/mim/mim-ref/1.0");
        ns.Add("xhtml", "http://www.w3.org/1999/xhtml");
        ns.Add("xlink", "http://www.w3.org/1999/xlink");
        ns.Add("xs", "http://www.w3.org/2001/XMLSchema");
        ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        
        var settings = new XmlWriterSettings
        {
            Indent = true,
            Encoding = new UTF8Encoding(false),
            OmitXmlDeclaration = false,
            NewLineHandling = NewLineHandling.Replace
        };
        using (var stream = new StringWriter())
        using (var writer = XmlWriter.Create(stream, settings))
        {
            var xsiSchemaLocation = new XmlSerializerNamespaces(ns);
            serializer.Serialize(writer, informatieModel, xsiSchemaLocation);
            var xml = stream.ToString();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(xml);
        }
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        
    }
}