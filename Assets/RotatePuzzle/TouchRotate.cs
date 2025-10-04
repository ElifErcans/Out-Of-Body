using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TouchRotate : MonoBehaviour, IInteractable
{
    bool isTurning=false;
    public RotationState RotationState;
    public void Interact()
    {
        //if (!GameControl.youWin)
        if (!isTurning)
        {
            isTurning = true;

            print("transform.eulerAngles.y " + transform.eulerAngles.y);
            transform.DORotate(new Vector3(0, transform.eulerAngles.y + 90f, 0), 0.2f).OnComplete(
                HandleAfterRotate             
                );
           // rotationState = rot;

        }
        switch (RotationState)  
        {
            case RotationState.top:
                RotationState = RotationState.right;
                break;
            case RotationState.right:
                RotationState = RotationState.bottom;
                break;
            case RotationState.bottom:
                RotationState = RotationState.left;
                break;
            case RotationState.left:
                RotationState = RotationState.top;
                break;
        }  

    }

    private void HandleAfterRotate()
    {
        isTurning = false;
        RotationPuzzle.instance.CheckPuzzleState();
    }
   

}
