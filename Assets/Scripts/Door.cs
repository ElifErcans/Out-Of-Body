using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour, IInteractable
{
    bool isOpened = false;
    [SerializeField] float animationDuration = 0.8f;
    [SerializeField] Ease easeType;
    public void Interact()
    {  
        if (!isOpened)
        {
            transform.parent.transform.DORotate(new Vector3(0, 60, 0), animationDuration).SetEase(easeType);
            isOpened = true;
        }
        else
        {
            transform.parent.transform.DORotate(new Vector3(0, -90, 0), animationDuration).SetEase(easeType);
            isOpened = false;
        }
        
    }

}
