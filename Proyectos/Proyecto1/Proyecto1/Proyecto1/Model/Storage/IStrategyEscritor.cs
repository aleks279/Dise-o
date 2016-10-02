using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Storage
{
    public interface IStrategyEscritor
    {
        void Escribir(String pAlgoritmo, String pModo, String pResultado);
        void setFilePath(String pFilePath);
    }
}
