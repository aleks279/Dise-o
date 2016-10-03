using Proyecto1.Control;
using Proyecto1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class ConsoleUI
    {
        private string entryData;
        private string results;
        private string kindFile;
        private string lastAlgorithm;
        private string lastKindAlgorithm;

        private ConsoleKeyInfo op;
        private EncryptDecryptController controllerEncrypt;
        private SaveController controllerSave;

        public ConsoleUI()
        {
            entryData = "Hola Mundo!";
            results = "aloH odnuM";
            kindFile = "TXT";
            this.lastKindAlgorithm = "encriptación";
            this.lastAlgorithm = "Transposición letra a letra";
        }

        public void setController(EncryptDecryptController pControllerEncrypt, SaveController pControllerSave)
        {
            controllerEncrypt = pControllerEncrypt;
            controllerSave = pControllerSave;
        }

        public void init()
        {

            do
            {

                showMainMenu();
                try
                {
                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        case ConsoleKey.E:
                            startEncodeMenu();
                            break;
                        case ConsoleKey.D:
                            startDecodeMenu();
                            break;
                        case ConsoleKey.G:
                            startSaveMenu();
                            break;
                        case ConsoleKey.Escape:
                            dispose();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en proceso");
                    Console.ReadKey();
                }
                
            } while (op.Key != ConsoleKey.Escape);
        }
        public string decorateHeader(string tipoOp, string pAlgoritmo, string modifiedData)
        {
            string resultado = "Tipo de operación: ";
            resultado += tipoOp + ", Método: " + pAlgoritmo + ", Resultado: " + modifiedData;
            return resultado;
        }

        private void dispose()
        {
            showLastMessage();
            Console.ReadKey();
        }

        private void startEncodeMenu()
        {
            showEncodeMenu();
            op = Console.ReadKey(true);
            showRequestToUser();
            this.lastKindAlgorithm = "encriptación";
            switch (op.Key)
            {
                case ConsoleKey.S:
                    //llamada a evento de vigenere
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Sustitución Vigénere";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.encrypt(entryData, lastAlgorithm));
                    break;
                case ConsoleKey.T:
                    //llamada a evento de transposicion
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Transposición letra a letra";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.encrypt(entryData, lastAlgorithm));
                    break;
                case ConsoleKey.B:
                    //llamada a evento de cod binaria
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Codificación binaria";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.encrypt(entryData, lastAlgorithm));
                    break;
                case ConsoleKey.C:
                    //llamada a evento de vigenerecod telefonico
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Código telefónico";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.encrypt(entryData, lastAlgorithm));
                    break;
            }
        }

        private void startDecodeMenu()
        {
            showDecodeMenu();
            op = Console.ReadKey(true);
            this.lastKindAlgorithm = "desencriptación";
            showRequestToUser();
            
            switch (op.Key)
            {
                case ConsoleKey.S:
                    //llamada a evento de vigenere
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Sustitución Vigénere";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.decrypt(entryData, lastAlgorithm));
                    break;
                case ConsoleKey.T:
                    //llamada a evento de transposicion
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Transposición letra a letra";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.decrypt(entryData, lastAlgorithm));
                    break;
                case ConsoleKey.B:
                    //llamada a evento de cod binaria
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Codificación binaria";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.decrypt(entryData, lastAlgorithm));
                    break;
                case ConsoleKey.C:
                    //llamada a evento de vigenerecod telefonico
                    entryData = Console.ReadLine();
                    this.lastAlgorithm = "Código telefónico";
                    this.results = decorateHeader(lastKindAlgorithm, lastAlgorithm, this.controllerEncrypt.decrypt(entryData, lastAlgorithm));
                    break;
            }
        }

        private void startSaveMenu()
        {
            showSaveMenu();
            op = Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Digite el nombre del archivo a guardar:");

            switch (op.Key)
            {
                case ConsoleKey.T:
                    this.kindFile = "TXT";
                    break;
                case ConsoleKey.P:
                    this.kindFile = "PDF";
                    break;
                case ConsoleKey.X:
                    this.kindFile = "XML";
                    break;
            }
            Console.WriteLine("Digite el nombre del archivo:");
            entryData = Console.ReadLine();
            if(isNotEmptyString(entryData))
                this.controllerSave.save(this.results, this.lastAlgorithm, this.lastKindAlgorithm, kindFile, entryData);
            
        }
        
        private void showMainMenu()
        {
            
            Console.Clear(); //Limpiar la pantalla
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=================Sistema Encriptación========================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[E]Encriptar\t");
            Console.Write("[D]Desencriptar\t");
            Console.Write("[G]Guardar resultados\t");
            Console.Write("[Esc]Salir\t\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-------Datos de entrada-------");
            Console.WriteLine(entryData);
            Console.WriteLine("------------------------------");
            Console.WriteLine("-------Datos de resultado-----");
            Console.WriteLine(results);
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=============================================================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Seleccione opción...");
        }

        private void showEncodeMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Encriptar");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------Encriptación-------");
            Console.WriteLine("Seleccione Metodo de Encriptación:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[S]Sustitución Vigenére");
            Console.WriteLine("[T]Transposición");
            Console.WriteLine("[B]Codificación Binaria");
            Console.WriteLine("[C]Código Telefónico");
            Console.WriteLine("[V]Volver\t");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------");
        }

        private void showDecodeMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Desencriptar");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------Desencriptación-------");
            Console.WriteLine("Seleccione Metodo de Desencriptar:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nota: se desencriptara los datos de resultado.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[S]Sustitución Vigenére");
            Console.WriteLine("[T]Transposición");
            Console.WriteLine("[B]Codificación Binaria");
            Console.WriteLine("[C]Código Telefónico");
            Console.WriteLine("[V]Volver\t");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------");
        }

        private void showSaveMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Guardando");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------Guardado-------");
            Console.WriteLine("Seleccione extensión de guardado:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[T] TXT");
            Console.WriteLine("[P] PDF");
            Console.WriteLine("[X] XML");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nota: Se guardara el último resultado procesado");
            
        }

        private void showRequestToUser()
        {
            Console.WriteLine("Digite información a procesar:");
        }

        private void showLastMessage()
        {
            Console.WriteLine("Gracias!!!");
        }
        
        private bool isNotEmptyString(String str)
        {
            return str != "";
        }
    }
}
