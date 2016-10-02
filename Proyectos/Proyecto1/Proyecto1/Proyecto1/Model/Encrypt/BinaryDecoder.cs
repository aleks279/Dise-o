using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Encrypt
{
    class BinaryDecoder: StrategyDecoder
    {
        private Hashtable codesLetters_Binary;
        private Hashtable codesBinary_Lettters;
        private List<string> tokenList;

        public BinaryDecoder()
        {
            codesLetters_Binary = new Hashtable();
            codesBinary_Lettters = new Hashtable();
            tokenList = new List<string>();
            setCodes();
        }

        public string decoder(string pString)
        {
            string result = "";
            readTokens(pString);
            for (int counter = 0; counter < tokenList.Count; counter++)
            {
                result = result + codesBinary_Lettters[tokenList.ElementAt(counter)];
            }
            return result;
        }

        public string encoder(string pString)
        {
            string result = "";
            for (int counter = 0; counter < pString.Length; counter++)
            {
                if (Char.IsWhiteSpace(pString, counter)) result = result + "* ";
                else
                {
                    result = result + codesLetters_Binary[(pString[counter]).ToString().ToLower()[0]] + " ";
                }
            }
            return result;
        }

        private void readTokens(string pString)
        {
            tokenList.Clear();
            string currentToken = "";
            for (int counter = 0; counter < pString.Length; counter++)
            {
                if (Char.IsWhiteSpace(pString, counter))
                {
                    tokenList.Add(currentToken);
                    currentToken = "";
                }
                else
                {
                    currentToken = currentToken + pString[counter];
                }
            }
            tokenList.Add(currentToken);
        }

        private void setCodes()
        {
            codesLetters_Binary.Add('a', "00000"); codesBinary_Lettters.Add( "00000", 'a');
            codesLetters_Binary.Add('b', "00001"); codesBinary_Lettters.Add( "00001", 'b');
            codesLetters_Binary.Add('c', "00010"); codesBinary_Lettters.Add( "00010", 'c');
            codesLetters_Binary.Add('d', "00011"); codesBinary_Lettters.Add( "00011", 'd');
            codesLetters_Binary.Add('e', "00100"); codesBinary_Lettters.Add( "00100", 'e');
            codesLetters_Binary.Add('f', "00101"); codesBinary_Lettters.Add( "00101", 'f');
            codesLetters_Binary.Add('g', "00110"); codesBinary_Lettters.Add( "00110", 'g');
            codesLetters_Binary.Add('h', "00111"); codesBinary_Lettters.Add( "00111", 'h');
            codesLetters_Binary.Add('i', "01000"); codesBinary_Lettters.Add( "01000", 'i');
            codesLetters_Binary.Add('j', "01001"); codesBinary_Lettters.Add( "01001", 'j');
            codesLetters_Binary.Add('k', "01010"); codesBinary_Lettters.Add( "01010", 'k');
            codesLetters_Binary.Add('l', "01011"); codesBinary_Lettters.Add( "01011", 'l');
            codesLetters_Binary.Add('m', "01100"); codesBinary_Lettters.Add( "01100", 'm');
            codesLetters_Binary.Add('n', "01101"); codesBinary_Lettters.Add( "01101", 'n');
            codesLetters_Binary.Add('o', "01110"); codesBinary_Lettters.Add( "01110", 'o');
            codesLetters_Binary.Add('p', "01111"); codesBinary_Lettters.Add( "01111", 'p');
            codesLetters_Binary.Add('q', "10000"); codesBinary_Lettters.Add( "10000", 'q');
            codesLetters_Binary.Add('r', "10001"); codesBinary_Lettters.Add( "10001", 'r');
            codesLetters_Binary.Add('s', "10010"); codesBinary_Lettters.Add( "10010", 's');
            codesLetters_Binary.Add('t', "10011"); codesBinary_Lettters.Add( "10011", 't');
            codesLetters_Binary.Add('u', "10100"); codesBinary_Lettters.Add( "10100", 'u');
            codesLetters_Binary.Add('v', "10101"); codesBinary_Lettters.Add( "10101", 'v');
            codesLetters_Binary.Add('w', "10110"); codesBinary_Lettters.Add( "10110", 'w');
            codesLetters_Binary.Add('x', "10111"); codesBinary_Lettters.Add( "10111", 'x');
            codesLetters_Binary.Add('y', "11000"); codesBinary_Lettters.Add( "11000", 'y');
            codesLetters_Binary.Add('z', "11001"); codesBinary_Lettters.Add( "11001", 'z');
                                                   codesBinary_Lettters.Add("*", ' ');
        }
    }
}
