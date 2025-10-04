using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Hexagon : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform draggingObjectRectTransform;
    private void Awake()
    {
        draggingObjectRectTransform = transform as RectTransform;
        //basePosition = draggingObjectRectTransform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(draggingObjectRectTransform, eventData.position, eventData.pressEventCamera,
            out var globalMousePosition))
        {

            draggingObjectRectTransform.position = globalMousePosition;
            //Vector3.SmoothDamp(draggingObjectRectTransform.position,
            //globalMousePosition, ref velocity, dampingSpeed);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    
}
