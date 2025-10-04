using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelPuzzle : Singleton<TelPuzzle>
{
    [SerializeField] public int[] trueTelOrder;
    private int[] currentTelOrder = new int[6];
    [SerializeField] private GameObject tablo;
    private int currentTelIndex = 0;
    [SerializeField] AudioClip ses;

    public void CheckTelSound(int index)
    {
        Debug.Log(index);
        currentTelOrder[currentTelIndex] = index;
        currentTelIndex++;
        if (currentTelIndex == trueTelOrder.Length)
        {
            currentTelIndex = 0;
            for (int i = 0; i < trueTelOrder.Length; i++)
            {
                if (currentTelOrder[i] != trueTelOrder[i])
                {
                    Debug.Log("Wrong");
                    //Array.Clear(currentTelOrder,0,currentTelOrder.Length);
                    ClearArray();
                    return;
                }
            }

            Debug.Log("Correct");
            tablo.transform.position = new Vector3(tablo.transform.position.x, 1.5f, tablo.transform.position.z);
            AudioManager.instance.PlayArpSounds(ses);

            ClearArray();
            // Array.Clear(currentTelOrder, 0, currentTelOrder.Length);
        }
    }

    public void ClearArray()
    {
        print("Liste Temizlendi");
        currentTelIndex= 0;
        Array.Clear(currentTelOrder, 0, currentTelOrder.Length);
    }
}