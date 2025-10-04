using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Drawer : MonoBehaviour, IInteractable
{
    bool isOpened = false;
    [SerializeField] float animationDuration = 0.8f;
    [SerializeField] Ease easeType;

    [SerializeField] float moveDistance = 1f;
    [SerializeField] Transform movingPosition;
    [SerializeField] Vector3 movingDirection;
    
    float defaultXPosition;
    Vector3 defaultPosition;
    private void Start()
    {
        //defaultXPosition = transform.localPosition.x;
        defaultPosition = transform.position;
    }
    public void Interact()
    {
        if (!isOpened)
        {
            transform.DOMove( movingPosition.position, animationDuration);
            isOpened = !isOpened;
            //print("isOpened true");
            return;           
        }
        else
        {
            transform.DOMove(defaultPosition, animationDuration);
            isOpened = !isOpened;
            //print("isOpened false" );
        }     
    }

}
