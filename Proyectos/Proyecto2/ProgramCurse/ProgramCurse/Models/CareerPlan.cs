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

public class CareerPlan: DocumentContainer
{
    private string planId;

    private string faculty;

    private string career;

    public DocumentState state;

    public CareerPlan(string pPlanId, string pFaculty, string pCareer, DocumentState pState, DocumentContext pDocument) : base(pDocument)
    {
        this.planId = pPlanId;
        this.faculty = pFaculty;
        this.career = pCareer;
        this.state = pState;
    }

    public void changeState(DocumentState pState)
    {
        this.state = pState;
    }

    public string getPlanID()
    {
        return this.planId;
    }

    public string getFaculty()
    {
        return this.faculty;
    }

    public string getCareer()
    {
        return this.career;
    }

    public override void addComponent(string pParentID, Component pComponent, UserType pType)
    {
        throw new NotImplementedException();
    }

    public override void editComponent(string pID, Component pComponentModified, UserType pType)
    {
        throw new NotImplementedException();
    }

    public override void removeComponent(string pId, UserType pType)
    {
        throw new NotImplementedException();
    }

    public override Component getComponent(string pId)
    {
        throw new NotImplementedException();
    }
}

