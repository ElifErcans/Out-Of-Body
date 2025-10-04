using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Book : MonoBehaviour, IInteractable
{
    public int bookIndex; 
    public static bool isSelected = false;

    private Transform player;

    public static event Action<bool> OnBookSelected;

    Collider bookCollider;

    // mouse t�klamaya timer ata 
    // ya da dotween oldu�u yerlerde scale ayar yapma, dotween arka planda 

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tags.Player).transform;
        bookCollider = GetComponent<Collider>();
    }

    private void OnEnable()
    {
        OnBookSelected += UpdateBookState;
    }
    private void OnDisable()
    {
        OnBookSelected -= UpdateBookState;
    }
    public void Interact()
    {

        if(Player.selectedBook==null)
        {
            if (!isSelected)
            {
                transform.parent = player.GetChild(0).GetChild(0);
                //transform.DOLocalMove(Vector3.zero, 0.5f);
                Player.selectedBook = gameObject;
                GetComponent<Collider>().enabled = false;
                // OnBookSelected(isSelected);

                transform.DOLocalMove(Vector3.zero, 0.5f);
                   

                isSelected = true;
                Player.selectedBook = gameObject;
            }
        }
      
    }

    public void UpdateBookState(bool isActive)
    {
        if (isActive)
        {
            bookCollider.enabled = false;
        }
        else
        {
            bookCollider.enabled = true;
        }

        print("bookCollider.enabled" + bookCollider.enabled);
    }


}
