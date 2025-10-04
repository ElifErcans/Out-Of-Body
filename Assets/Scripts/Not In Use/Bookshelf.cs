using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookshelf : MonoBehaviour
{
    [SerializeField] Transform[] shelfBookPlaces = new Transform[10];

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            shelfBookPlaces[i] = transform.GetChild(i);
        }
    }
}
