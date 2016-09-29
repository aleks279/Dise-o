using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    interface IStrategyEscritor<T>
    {
        void Escribir(String pTexto, String pAlgoritmo, String pModo, String pResultado);
        void setFilePath(String pFilePath);
    }
}
