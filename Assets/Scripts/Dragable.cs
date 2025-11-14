using System;
using UnityEngine;
using UnityEngine.EventSystems;


public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public Transform parentAfterDrag;
    [SerializeField] public String Tag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        GetComponent<UnityEngine.UI.Image>().raycastTarget = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        GetComponent<UnityEngine.UI.Image>().raycastTarget = true;

    }

    public void checkAnswer()
    {
        
    }
}
