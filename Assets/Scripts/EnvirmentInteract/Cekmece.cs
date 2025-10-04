using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Cekmece : MonoBehaviour,IInteractable
{
   [SerializeField] private Transform startPosition;
   [SerializeField] private Vector3 endPosition;
   bool isOpen = false;

   public void Interact()
   {
      if (!isOpen)
      {
         Debug.Log("Açılıyor");
         transform.localPosition+=new Vector3(0,0,5f);
         isOpen = true;

      }
      else
      {
         transform.position= new Vector3(0,0,0);
         isOpen = false;
      }
   }
}
