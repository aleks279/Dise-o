using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class DocumentContainer
{
    private DocumentContext document;

    public DocumentContainer(DocumentContext pDocument)
    {
        this.document = pDocument;
    }

    public Component getComponent(string pId)
    {
        return this.document.getComponent(pId);
    }

    public void activateLevel(UserType pLevel, string pComponentId)
    {
        Component toActivate = this.document.getComponent(pComponentId);
        toActivate.activateAccessLevel(pLevel);
    }

    public void deactivateLevel(UserType pLevel, string pComponentId)
    {
        Component toDeactivate = this.document.getComponent(pComponentId);
        toDeactivate.activateAccessLevel(pLevel);
    }

    public void addComponent(string pParentID, Component pComponent, UserType pType)
    {
        if (this.document.getAccessLevels()[pType])
        {
            Component parentComponent = this.document.getComponent(pParentID);
            try
            {
                if (!parentComponent.isLeaf())
                {
                    CompositeElement toAdd = (CompositeElement)parentComponent;
                    toAdd.add(pComponent);
                }
                else
                {
                    Console.WriteLine("Error agregregando elementos al componente: " + parentComponent.getId());
                }
            }
            catch(NullReferenceException err)
            {
                Console.WriteLine("Error componente parent no existe");
            }
        }
        else
        {
            Console.WriteLine("No tiene permisos para modificar este componente");
        }

    }

    public void removeComponent(string pId, UserType pType)
    {
        if (this.document.getAccessLevels()[pType])
        {
            this.document.remove(pId);
        }
        else
        {
            Console.WriteLine("No tiene permisos para modificar este componente");
        }
    }

    public DocumentContext getDocument()
    {
        return this.document;
    }

    public void setDocument(DocumentContext pDocument)
    {
        this.document = pDocument;
    }

    public override string ToString()
    {
        return this.document.ToString();
    }
}
