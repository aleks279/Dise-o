using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Model.Storage;

namespace Proyecto1.Control
{
    public class SaveController
    {
        private ContextSave _Contexto;
        public SaveController(ContextSave pContexto)
        {
            this._Contexto = pContexto;
        }
        public void save(string pResultado, string pAlgoritmo, string pTipoOp, string pFormato, string pDireccion)
        {
            this._Contexto.execute(pResultado, pAlgoritmo, pTipoOp, pFormato, pDireccion);
        }
        public List<string> obtenerMisFormatos()
        {
            return _Contexto.getNombresFormatos();
        }
    }
}
