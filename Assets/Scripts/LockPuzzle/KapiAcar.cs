using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KapiAcar : MonoBehaviour,IInteractable
{
    private bool isOpened = false;
    public void Interact()
    {
        if(PlayerPrefs.GetInt("Kilit") == 1)
        {
            if (!isOpened)
            {
                // transform.parent.transform.parent.
               transform.DORotate(new Vector3(-45, -15, 90), 0.5f).
                    SetEase(Ease.OutBack).OnComplete(()=>{GetComponent<MeshCollider>().enabled = false;});
                isOpened = true;
            }
        }
    }

}
