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

public class Caretaker
{
    private List<DocumentMemento> MementoList;

    public Caretaker()
    {
        this.MementoList = new List<DocumentMemento>();
    }

	public void add(DocumentMemento pMemento)
	{
        this.MementoList.Add(pMemento);
	}

	public DocumentMemento getLastMemento()
	{
        return this.MementoList.Last<DocumentMemento>();
	}

}
