using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Encrypt
{
    public class ContextEncrypt
    {
        Dictionary<string, StrategyDecoder> _Metodos;
        public void setMetodos(Dictionary<string, StrategyDecoder> pMetodos)
        {
            this._Metodos = pMetodos;
        }
        public List<string> getNombresMetodos()
        {
            return this._Metodos.Keys.ToList();
        }

        public string execute(string pData, string pMetodo, bool encrypt)
        {
            if (encrypt)
            {
                StrategyDecoder encoderDecoder;
                this._Metodos.TryGetValue(pMetodo, out encoderDecoder);
                return encoderDecoder.encoder(pData);
            }
            else
            {
                StrategyDecoder encoderDecoder;
                this._Metodos.TryGetValue(pMetodo, out encoderDecoder);
                return encoderDecoder.decoder(pData);
            }
        }
        
    }
}
