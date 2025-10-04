using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPuzzle : Singleton<RotationPuzzle>
{
    [SerializeField]
    private TouchRotate[] pictures;
    [SerializeField]
    private RotationState[] correctOrder;

    [SerializeField] private GameObject ipucuResmi;
    public static bool youWin;

    void Start() 
    {
        youWin = false;
    }

    public void CheckPuzzleState()
    {
        for(int i = 0; i < pictures.Length; i++)
        {
            if(pictures[i].RotationState != correctOrder[i])
            {
                Debug.Log("return");
                return;
            }
        }

        Debug.LogWarning("win win win");
        youWin = true;
        ipucuResmi.SetActive(true);
        gameObject.SetActive(false);              
    }
}

public enum RotationState
{
    top,
    right,
    bottom,
    left
}
