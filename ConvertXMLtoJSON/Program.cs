using Newtonsoft.Json;
using System.Text;
using System.Xml;

XmlDocument doc = new XmlDocument();

using (StreamReader streamReader = new StreamReader("C:\\Users\\Admin\\source\\repos\\ConvertXMLtoJSON\\ConvertXMLtoJSON\\XmlFile\\BangTyGiaVangSJC.xml", Encoding.UTF8))
{
    var contents = streamReader.ReadToEnd();
    doc.LoadXml(contents);
}
XmlNode root = doc.DocumentElement;
root.RemoveChild(root.FirstChild);
string json = JsonConvert.SerializeXmlNode(root);
Console.WriteLine(json);