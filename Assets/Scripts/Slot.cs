using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject droppedObject = eventData.pointerDrag;
            Dragable dragable = droppedObject.GetComponent<Dragable>();
            dragable.parentAfterDrag = this.transform;
        }
    }

}
