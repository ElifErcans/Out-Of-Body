using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RotateCylinder : MonoBehaviour, IInteractable
{
    [SerializeField] Ease ease;

    public int[] code;
    public int orderIndex;
    public int rotateArc;
    private int index = 1;
    private bool isRotating = false;
    private float x, y = 0, z = 0;
    private Vector3 currentEulerAngles;
    private Quaternion targetRotation;

    private void Start()
    {
        LockPuzzle.instance.CheckCode(code[0], orderIndex);
        targetRotation = Quaternion.Euler(x, y, z);
        //x = transform.eulerAngles.x;
        //print(x);
    }


    public void Interact()
    {
        //  Debug.Log("interact");
        if (!isRotating)
        {
            if (index >= code.Length)
            {
                index = 0;
            }
            // x -= 90;
            // print(x);
            // currentEulerAngles += new Vector3(x, y, z);
            // transform.eulerAngles = currentEulerAngles;

            //Debug.Log(index);
           // isRotating = true;
            LockPuzzle.instance.CheckCode(code[index], orderIndex);

            //
            targetRotation.x -= 90; 
            // Debug.Log("asdsadads");
            transform.rotation=Quaternion.Euler(
                targetRotation.x,
                transform.eulerAngles.y,
                transform.eulerAngles.z);
            // transform.eulerAngles= new Vector3(transform.eulerAngles.x + rotateArc,0, 180);
            // transform.DORotate(new Vector3( 0,0 , transform.rotation.z+90), 1f).SetEase(ease);
            // transform.DOLocalRotate(new Vector3(
            //         targetRotation.x,
            //         transform.eulerAngles.y,
            //         transform.eulerAngles.z),
            //     0.5f).OnComplete(() => { isRotating = false; });
            //
            // transform.Rotate(new Vector3(
            //     transform.localEulerAngles.x + 90,
            //     transform.eulerAngles.y,
            //     transform.eulerAngles.z));
              
            index++;
        }
    }
}