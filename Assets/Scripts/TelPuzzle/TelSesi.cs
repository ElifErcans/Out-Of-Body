using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelSesi : MonoBehaviour,IInteractable
{
    [SerializeField] AudioClip ses;
    // Start is called before the first frame update
    [SerializeField] public int indexTel;
    
    public void Interact()
    {
        Debug.Log("Ses Calindi açıldı");  ///TODO buraya ses çalma kodu yazılacak
        AudioManager.instance.PlayArpSounds(ses);
        TelPuzzle.instance.CheckTelSound(indexTel);
        
    }
}
