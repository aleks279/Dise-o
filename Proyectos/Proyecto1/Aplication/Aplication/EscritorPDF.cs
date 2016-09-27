using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using iTextSharp.text.pdf;
using iTextSharp.text;
// Para que esto funcione, hay que instalar iTextSharp
// 1. Abrir la consola de paquetes de NuGet
// 2. Correr el comando: Install-Package iTextSharp
// 3. Enjoy!

namespace Aplication
{
    class EscritorPDF : IStrategyEscritor<EscritorPDF>
    {
        private String filePath = @"salida.pdf";

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
                    var doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                    doc.Open();

                    doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString()));
                    doc.Add(new Paragraph("Algoritmo: " + pAlgoritmo));
                    doc.Add(new Paragraph("Modo: " + pModo));
                    doc.Add(new Paragraph("Texto Original: " + pTexto));
                    doc.Add(new Paragraph("Resultado: " + pResultado));

                    doc.Close();
                }
                else
                {
                    Document newDoc = new Document();
                    PdfCopy writer = new PdfCopy(newDoc, new FileStream(filePath, FileMode.Create));

                    newDoc.Open();

                    PdfReader reader = new PdfReader(filePath);
                    reader.ConsolidateNamedDestinations();

                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        PdfImportedPage page = writer.GetImportedPage(reader, i);
                        writer.AddPage(page);
                    }

                    newDoc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString()));
                    newDoc.Add(new Paragraph("Algoritmo: " + pAlgoritmo));
                    newDoc.Add(new Paragraph("Modo: " + pModo));
                    newDoc.Add(new Paragraph("Texto Original: " + pTexto));
                    newDoc.Add(new Paragraph("Resultado: " + pResultado));

                    reader.Close();
                    writer.Close();
                    newDoc.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
