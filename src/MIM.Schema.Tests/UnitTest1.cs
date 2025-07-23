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
            naam = "test",
            MIMVersie = InformatiemodelMIMVersie.Item111
        };
        
        
        XmlSerializer serializer = new XmlSerializer(typeof(Informatiemodel));

        // Serialize the object to a string
        using (StringWriter writer = new StringWriter())
        {
            serializer.Serialize(writer, informatieModel);
            string xmlString = writer.ToString();
            Console.WriteLine(xmlString);
        }

        // Serialize the object to a file
        using (FileStream file = File.Create("informatiemodel.xml"))
        {
            serializer.Serialize(file, informatieModel);
        }
        Assert.Pass();
    }
}