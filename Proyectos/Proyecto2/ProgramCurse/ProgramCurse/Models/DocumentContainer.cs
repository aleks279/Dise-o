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

    public DocumentContext getDocument()
    {
        return this.document;
    }

    public abstract Component getComponent(string pId);

    public void activateLevel(int pLevel, string pComponentId)
    {
        Component toActivate = this.document.getChild(pComponentId);
        toActivate.activateAccessLevel(pLevel);
    }

    public void deactivateLevel(int pLevel, string pComponentId)
    {
        Component toDeactivate = this.document.getChild(pComponentId);
        toDeactivate.activateAccessLevel(pLevel);
    }

    public abstract void addComponent(string pParentID, Component pComponent, UserType pType);

    public abstract void removeComponent(string pId, UserType pType);

    public abstract void editComponent(string pID, Component pComponentModified, UserType pType);

}
