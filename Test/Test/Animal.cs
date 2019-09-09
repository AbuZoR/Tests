using System;
using System.Reflection;
using System.Xml;

namespace Test
{
    public abstract class Animal
    {
        public int legs;
        public string noise;

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public string MakeNoise
        {
            get { return noise; }
            set { noise = value; }
        }

        public string ToXML(object obj)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", string.Empty);
            xmlDoc.PrependChild(xmlDec);

            XmlElement xmlEle = xmlDoc.CreateElement($"{obj.GetType().Name}");
            xmlDoc.AppendChild(xmlEle);

            XmlElement elem = null;
            Type idType = obj.GetType();

            foreach (PropertyInfo pInfo in idType.GetProperties())
            {
                object o = pInfo.GetValue(obj, null);
                elem = xmlDoc.CreateElement(pInfo.Name);
                elem.InnerText = o.ToString();
                xmlEle.AppendChild(elem);
            }

            return xmlDoc.OuterXml;
        }
    }
}