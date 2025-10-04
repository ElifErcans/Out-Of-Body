using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BookShelfPace : MonoBehaviour, IInteractable
{
    public int bookPlaceIndex;
    public bool hasCorrectBook=false;
    public static bool isShelfPlaceActive = false;
    Collider shelfCollider;
    
    private void Start()
    {
        shelfCollider = GetComponent<Collider>();

        Book book = transform.GetChild(1).GetComponent<Book>();
        if(book != null)
        if (book.bookIndex == bookPlaceIndex || bookPlaceIndex == 0)
        {          
            hasCorrectBook = true;
            print(hasCorrectBook);
        }
    }
    private void OnEnable()
    {
        Book.OnBookSelected += UpdateShelfState;
    }

    private void OnDisable()
    {
        Book.OnBookSelected -= UpdateShelfState;
    }
    public void Interact()
    {
        if (Player.selectedBook != null)
        {
            Player.selectedBook.transform.parent = transform;
            Player.selectedBook.transform.localScale = Vector3.one;
            Player.selectedBook.transform.position = new Vector3(0, 0, -0.01f);
            Player.selectedBook.transform.localPosition = new Vector3(0, 0, -0.01f);

            Player.canClick = false;
            Player.selectedBook.transform.DORotate(transform.eulerAngles, 0.3f).OnComplete(MakeBookSelectable);

            if (bookPlaceIndex == Player.selectedBook.GetComponent<Book>().bookIndex)
            {
                BookPuzzle.instance.CheckPlacesInShelf();
            }
        }

    }
    private void MakeBookSelectable()
    {
        Player.selectedBook.GetComponent<Collider>().enabled = true;
        //Player.selectedBook.transform.localScale = new Vector3(2.12766f, 1.204819f, 1.111914f);
        Player.selectedBook.transform.position = new Vector3(0, 0, -0.01f);
        Player.selectedBook.transform.localPosition = new Vector3(0, 0, -0.01f);
        Book.isSelected = false;
        Player.selectedBook = null;
        Player.instance.onInteract = false;
        Player.canClick = true;
    }

    public void UpdateShelfState(bool isActive)
    {
        if (isActive)
        {
            shelfCollider.enabled = true;
        }
        else
        {
            shelfCollider.enabled = false;
        }
        print("bookCollider.enabled" + shelfCollider.enabled);
    }


}
