﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramCurse.Models
{
    public class DocumentMemento
    {
        private DocumentContext state;

        public DocumentMemento(DocumentContext pState)
        {
            this.state = pState;
        }

        public DocumentContext getState()
        {
            return this.state;
        }

        public void setState(DocumentContext pState)
        {
            this.state = pState;
        }

    }

}