using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Encrypt
{
    public class Transposition : StrategyDecoder
    {
        private List<String> tokenList;

        public Transposition()
        {
            tokenList = new List<string>();
        }

        public string decoder(string pString)
        {
            readTokens(pString);
            return coder(pString);
        }

        public string encoder(string pString)
        {
            readTokens(pString);
            return coder(pString);
        }

        private string coder(string pString)
        {
            
            string result = "";
            for (int counter = 0; counter < this.tokenList.Count; counter++)
            {
                result = result+turnPosition(tokenList.ElementAt(counter))+" ";
            }
            return result;
        }

        private void readTokens(String pString)
        {
            tokenList.Clear();
            string currentToken = "";
            for (int counter = 0; counter < pString.Length; counter++)
            {
                if (Char.IsWhiteSpace(pString, counter))
                {
                    this.tokenList.Add(currentToken);
                    currentToken = "";
                }
                else
                {
                    currentToken = currentToken + pString[counter];
                }
            }
            this.tokenList.Add(currentToken);
           
        }

        private String turnPosition(String pString)
        {
            string currentToken = "";
            for (int counter = 0; counter < pString.Length; counter++)
            {
                currentToken = pString[counter] + currentToken ;
               
            }
            return currentToken;
        }
        
    }
}
