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
    public class CurricularManager : User
    {

        public CurricularManager(string pName, string pEmail) : base(pName, pEmail)
        {

        }

        public override void addComponent(string pParentID, Component pComponent)
        {
            base.getContainer().addComponent(pParentID, pComponent, UserType.CurricularManager);
        }

        public override DocumentContext getDocument()
        {
            return base.getContainer().getDocument();
        }

        public override void removeComponent(string pId)
        {
            base.getContainer().removeComponent(pId, UserType.CurricularManager);
        }

        public override Component getComponent(string pId)
        {
            return base.getContainer().getComponent(pId);
        }

        public override string ToString()
        {
            return base.getContainer().ToString();
        }
    }

}