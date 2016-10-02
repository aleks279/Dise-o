using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Model.Encrypt;

namespace Proyecto1.Control
{
    public class EncryptDecryptController
    {
        public ContextEncrypt _Contexto;
        public EncryptDecryptController(ContextEncrypt pContexto)
        {
            this._Contexto = pContexto;
        }
        public List<string> getMisMetodos()
        {
            return this._Contexto.getNombresMetodos();
        }
        public string encrypt (string pData, string pMetodo)
        {
            return this._Contexto.execute(pData, pMetodo, true);
        }
        public string decrypt(string pData, string pMetodo)
        {
            return this._Contexto.execute(pData, pMetodo, false);
        }
    }
}
