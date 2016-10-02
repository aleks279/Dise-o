using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Encrypt
{
    public interface StrategyDecoder
    {
        String decoder(String pString);
        String encoder(String pString);
    }
}
