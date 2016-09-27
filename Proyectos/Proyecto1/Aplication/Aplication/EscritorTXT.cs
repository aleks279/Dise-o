using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Aplication
{
    class EscritorTXT : IStrategyEscritor<EscritorTXT>
    {
        string filePath = @"salida.txt";

        public void Escribir(String pTexto, String pAlgoritmo, String pModo, String pResultado) {
            try
            {
                if (!File.Exists(filePath))
                {
                    using(StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine("Fecha: " + DateTime.Now.ToString());
                        writer.WriteLine("Algoritmo: " + pAlgoritmo);
                        writer.WriteLine("Modo: " + pModo);
                        writer.WriteLine("Texto original:\n");
                        writer.Write(pTexto + "\n");
                        writer.WriteLine("Resultado:\n");
                        writer.WriteLine(pResultado);
                    }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine("Fecha: " + DateTime.Now.ToString());
                        writer.WriteLine("Algoritmo: " + pAlgoritmo);
                        writer.WriteLine("Modo: " + pModo);
                        writer.WriteLine("Texto original:\n");
                        writer.Write(pTexto + "\n");
                        writer.WriteLine("Resultado:\n");
                        writer.WriteLine(pResultado);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
