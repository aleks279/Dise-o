using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Model.Encrypt
{
    public class PhoneDecoder : StrategyDecoder
    {
        private List<List<String>> matrix;
        public PhoneDecoder()
        {
            setMatrix();
        }

        public string decoder(string pString)
        {
            string result = "";
            bool flagPosition = true;
            string currentElements = "";
            for (int counter = 0; counter < pString.Length; counter++)
            {
                if (pString[counter] == '*')
                {
                    result = result + " ";
                    flagPosition = true;
                }
                else if (pString[counter] != ' ')
                {
                    if (flagPosition)
                    {
                        currentElements = "";
                        currentElements = currentElements + pString[counter];
                        flagPosition = false;
                    }
                    else
                    {
                        currentElements = currentElements + pString[counter];
                        result = result + matrix[int.Parse(currentElements[0].ToString())-1][int.Parse(currentElements[1].ToString()) - 1]; 
                        currentElements = "";
                        flagPosition = true;
                    }
                }
            }
            return result;
        }
        
        public string encoder(string pString)
        {
            string result = "";
            for (int counter = 0; counter < pString.Length; counter++)
            {
                result= result + letterCoder(pString[counter].ToString()) + " ";
            }
            return result;
        }

        private string letterCoder(string pString)
        {
            string result = "";
            string lowcaseLetter = pString.ToLower();
            if (lowcaseLetter.Equals(" "))
                result = "*";
            else
                for (int counter = 0; counter < matrix.Count; counter++)
                {
                    if (matrix[counter].Contains(lowcaseLetter))
                    {
                        result = ((1 + counter)+"" + (1 + matrix[counter].FindIndex(lowcaseLetter.StartsWith))).ToString();
                    }
                }
            return result;
        }

        private void setMatrix()
        {
            matrix = new List<List<string>>();
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());
            matrix.Add(new List<string>());

            matrix[1].Add("a");
            matrix[1].Add("b");
            matrix[1].Add("c");

            matrix[2].Add("d");
            matrix[2].Add("e");
            matrix[2].Add("f");

            matrix[3].Add("g");
            matrix[3].Add("h");
            matrix[3].Add("i");

            matrix[4].Add("j");
            matrix[4].Add("k");
            matrix[4].Add("l");

            matrix[5].Add("m");
            matrix[5].Add("n");
            matrix[5].Add("o");


            matrix[6].Add("p");
            matrix[6].Add("q");
            matrix[6].Add("r");
            matrix[6].Add("s");

            matrix[7].Add("t");
            matrix[7].Add("u");
            matrix[7].Add("v");

            matrix[8].Add("w");
            matrix[8].Add("x");
            matrix[8].Add("y");
            matrix[8].Add("z");
        }
    }
}
