using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCurse.Models
{
    public class Curse
    {
        private string CurseCode;

        private string modality;

        private string name;

        private List<Curse> requisits;

        private List<Curse> correquisits;

        private List<Curse> requisitOf;

        public Curse(string pCode, string pModality, string pName, List<Curse> pRequisits, List<Curse> pCorrequisits, List<Curse> pRequisitOf)
        {
            this.CurseCode = pCode;
            this.modality = pModality;
            this.name = pName;
            this.requisits = pRequisits;
            this.correquisits = pCorrequisits;
            this.requisitOf = pRequisitOf;
        }

        public string getCurseCode()
        {
            return this.CurseCode;
        }

        public string getModality()
        {
            return this.modality;
        }

        public string getName()
        {
            return this.name;
        }
        public List<Curse> getRequisits()
        {
            return this.requisits;
        }
        public List<Curse> getCorrequisits()
        {
            return this.correquisits;
        }
        public List<Curse> getRequisitsOF()
        {
            return this.requisitOf;
        }
    }
}