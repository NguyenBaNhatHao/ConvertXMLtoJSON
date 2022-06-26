using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Xml;

XmlDocument doc = new XmlDocument();
var m_strFilePath = "https://sjc.com.vn/xml/tygiavang.xml";
string xmlStr;
using (var wc = new WebClient())
{
    xmlStr = wc.DownloadString(m_strFilePath);
}
doc.LoadXml(xmlStr);
XmlNode root = doc.DocumentElement;
root.RemoveChild(root.FirstChild);
var json = JsonConvert.SerializeXmlNode(root);
Console.WriteLine(json);  