using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ProgramCurse.Models.Storage
{
    public class StoragePDF
    {
        private String filePath = @"salida.pdf";

        public void setFilePath(String pFilePath)
        {
            this.filePath = pFilePath;
        }

        public void Escribir(String pInfo)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    var doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                    doc.Open();

                    doc.Add(new Paragraph(pInfo));

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
                    newDoc.Add(new Paragraph(pInfo));
                   

                    reader.Close();
                    writer.Close();
                    newDoc.Close();
                }
            }
            catch (Exception error)
            {
                Console.Write(error.Message);
            }
        }
    }
}
