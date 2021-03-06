﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Proyecto1.Model.Storage
{
    class EscritorTXT : IStrategyEscritor
    {
        private String filePath = @"salida.txt";

        public void setFilePath(String pFilePath)
        {
            this.filePath = pFilePath;
        }

        public void Escribir(String pAlgoritmo, String pModo, String pResultado) {
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
                        writer.WriteLine("Resultado:\n");
                        writer.WriteLine(pResultado);
                    }
                }
            }
            catch (Exception error)
            {
                Console.Write(error.Message);
            }
        }
    }
}
