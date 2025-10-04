using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPuzzle : Singleton<BookPuzzle>
{
    [SerializeField] BookShelfPace[] bookPlaces;
    private int dogrukitap = 0;
    public void CheckPlacesInShelf()
    {
        dogrukitap = 0;
        foreach(var item in bookPlaces)
        {
            if (!item.hasCorrectBook)
            {
                // print("return");
                return;
            }

            dogrukitap++;
            print(dogrukitap);

            if (dogrukitap >= 14)
            {
                print("asdhsnadhads");
            }
            //print("gdfgdfgsfs");
        }
        
        
    }
}

