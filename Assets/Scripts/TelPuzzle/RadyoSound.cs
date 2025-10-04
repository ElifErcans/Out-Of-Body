using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadyoSound : MonoBehaviour, IInteractable
{
    [SerializeField] private AudioClip _audioSource;
    bool isPlaying = false;

    public void Interact()
    {
        Debug.Log("Radyo Çalıyor");
        float lengthOfOriginalSound = _audioSource.length;
        StartCoroutine(delayedPlay(lengthOfOriginalSound));
    }

    IEnumerator delayedPlay(float timeToWait)
    {
        if (!isPlaying)
        {
            isPlaying = true;
            TelPuzzle.instance.ClearArray();
            AudioManager.instance.PlayArpSounds(_audioSource);
            yield return new WaitForSeconds(timeToWait);
            isPlaying = false;
        }
    }
}