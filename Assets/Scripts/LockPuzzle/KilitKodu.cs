using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilitKodu : MonoBehaviour,IInteractable
{
    private void Start()
    {
        PlayerPrefs.DeleteKey("Kilit");
    }

    public void Interact()
    {
        gameObject.SetActive(false);
        PlayerPrefs.SetInt("Kilit", 1);
    }
}
