using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Encrypt
{
    class SustitucionVigenere : StrategyDecoder
    {
        private readonly int DIFERENCE_AMOUNT = 2;
        private readonly int DIFERENCE_BY_POSITION = 1;

        private String lettersString;
        
        public SustitucionVigenere()
        {
            lettersString = "abcdefghijklmnopqrstuvwxyz";
        }
        
        public string decoder(string pString)
        {
            return coder(pString, -(DIFERENCE_BY_POSITION), -(DIFERENCE_AMOUNT));
        }
        
        public string encoder(string pString)
        {
            return coder(pString, DIFERENCE_BY_POSITION, DIFERENCE_AMOUNT);
        }

        private string coder(string pString, int pDiferenceByPosition, int pDiferenceAmount)
        {
            String result = "";
            int diferenceByPosition = pDiferenceByPosition;
            int diferenceAmount = pDiferenceAmount;
            for (int counter = 0; counter < pString.Length; counter++)
            {
                if (Char.IsWhiteSpace(pString, counter)) result = result + " ";
                else
                {
                    if (diferenceByPosition == pDiferenceByPosition) diferenceByPosition = 0;
                    else { diferenceByPosition = pDiferenceByPosition; }
                    result = result + lettersString[(getLetterPosition(pString[counter]) + diferenceAmount + diferenceByPosition) % lettersString.Length];
                }
            }
            return result;
        }

        private int getLetterPosition(char pLetter)
        {
            String lowcaseLetter = (pLetter+"").ToLower();
            
            for (int counter = 0; counter < lettersString.Length; counter++)
            {
                if (lowcaseLetter[0] == lettersString[counter])
                {
                    return counter;
                }
            }
            return 0;
        }

    }
}
