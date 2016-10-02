using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.View
{
    public interface IUserOperations
    {
        string encrypt(string pData);
        string decrypt(string pData);
        void save(string pResultado, string pAlgoritmo, string pTipoOp);
    }
}
