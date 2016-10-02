using Proyecto1.Model.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Storage
{
    public class ContextSave
    {
        Dictionary<string, IStrategyEscritor> _Formatos;
        public void setFormatos(Dictionary<string, IStrategyEscritor> pFormatos)
        {
            this._Formatos = pFormatos;
        }
        public List<string> getNombresFormatos()
        {
            return this._Formatos.Keys.ToList();
        }
        public void execute(string pResultado, string pAlgoritmo, string pTipoOp, string pFormato, string pDireccion)
        {
            IStrategyEscritor encoderDecoder;
            this._Formatos.TryGetValue(pFormato, out encoderDecoder);
            encoderDecoder.setFilePath(pDireccion);
            encoderDecoder.Escribir(pAlgoritmo, pTipoOp, pResultado);
            
        }
    }
}
