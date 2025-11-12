using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {

        GameObject droppedObject = eventData.pointerDrag;
        Dragable dragable = droppedObject.GetComponent<Dragable>();
        dragable.parentAfterDrag = this.transform;



    }
}
