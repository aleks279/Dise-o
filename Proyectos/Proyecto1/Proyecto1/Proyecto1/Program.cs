﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.View;
using Proyecto1.Control;
using Proyecto1.Model.Encrypt;
using Proyecto1.Model.Storage;
using Algoritmos;

namespace Proyecto1
{
    static class Program
    {

        public static void GraphicUI(SaveController pSaveControl, EncryptDecryptController pSaveEnDeController)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Se crea la interfaz gráfic de usuarios
            EncryptDecryptGUI encryptGUI = new EncryptDecryptGUI();
            encryptGUI.setController(pSaveEnDeController, pSaveControl);
            //Se definen las transiciones entre las ventanas
            encryptGUI.init();
            Application.Run(encryptGUI);
        }

        public static void ConsoleUI(SaveController pSaveControl, EncryptDecryptController pSaveEnDeController)
        {
            ConsoleUI encryptCUI = new ConsoleUI();
            encryptCUI.setController(pSaveEnDeController, pSaveControl);
            encryptCUI.init();
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            //Diccionarios de Formatos de escritura
            Dictionary<string, IStrategyEscritor> misFormatos = new Dictionary<string, IStrategyEscritor>();
            misFormatos.Add("PDF", new EscritorPDF());
            misFormatos.Add("TXT", new EscritorTXT());
            misFormatos.Add("XML", new EscritorXML());
            //Diccionarios de Métodos de encriptación
            Dictionary<string, StrategyDecoder> misMetodos = new Dictionary<string, StrategyDecoder>();
            misMetodos.Add("Sustitución Vigénere", new SustitucionVigenere());
            misMetodos.Add("Transposición letra a letra", new Transposition());
            misMetodos.Add("Código telefónico", new PhoneDecoder());
            misMetodos.Add("Codificación binaria", new BinaryDecoder());
            //Se crea el contexto de guardado
            ContextSave contextoSave = new ContextSave();
            contextoSave.setFormatos(misFormatos);
            //Se crea el contexto de encriptación
            ContextEncrypt contextoEncriptacion = new ContextEncrypt();
            contextoEncriptacion.setMetodos(misMetodos);
            //Se crean los controladores
            SaveController saveControl = new SaveController(contextoSave);
            EncryptDecryptController encryptControl = new EncryptDecryptController(contextoEncriptacion);

            //Seleccionar una de las dos interfaces
            GraphicUI(saveControl, encryptControl);
            ConsoleUI(saveControl, encryptControl);
        }
    }
}
