using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Aplication
{
    class EscritorXML : IStrategyEscritor<EscritorXML>
    {
        private String filePath = @"salida.xml";

        public void setFilePath(String pFilePath)
        {
            this.filePath = pFilePath;
        }

        public void Escribir(String pTexto, String pAlgoritmo, String pModo, String pResultado)
        {
            try
            {
                if(!File.Exists(filePath))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.NewLineOnAttributes = true;

                    using(XmlWriter writer = XmlWriter.Create(filePath, settings))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Salidas");
                        writer.WriteStartElement("Salida");

                        writer.WriteElementString("Fecha", DateTime.Now.ToString());
                        writer.WriteElementString("Algoritmo", pAlgoritmo);
                        writer.WriteElementString("Modo", pModo);
                        writer.WriteElementString("TextoOriginal", pTexto);
                        writer.WriteElementString("Resultado", pResultado);

                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Flush();
                        writer.Close();
                    }
                }
                else
                {
                    XDocument doc = XDocument.Load(filePath);
                    XElement root = doc.Element("Salidas");

                    IEnumerable<XElement> rows = root.Descendants("Salida");
                    XElement lastRow = rows.Last();

                    lastRow.AddAfterSelf(
                        new XElement("Salida",
                            new XElement("Fecha", DateTime.Now.ToString()),
                            new XElement("Algoritmo", pAlgoritmo),
                            new XElement("Modo", pModo),
                            new XElement("TextoOriginal", pTexto),
                            new XElement("Resultado", pResultado)
                        )
                    );

                    doc.Save(filePath);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
