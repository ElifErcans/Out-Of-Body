using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : Singleton<Player>
{
    private Camera _cam;
    private InputAction click;
    [SerializeField] float interactionDistance = 45f;

    public bool onInteract = false;

    public static GameObject selectedBook;

    public static bool canClick = true;
    public override void Awake()
    {
        base.Awake();

        _cam = Camera.main;
        InteractWithOtherObjects();

    }
    void OnDrawGizmos()
    {
        // Draws a 5 unit long red line in front of the object
        if (_cam != null)
        {
            Gizmos.color = Color.red;
            Vector3 direction = _cam.transform.TransformDirection(Vector3.forward) * interactionDistance;
            Gizmos.DrawRay(_cam.transform.position, direction);
        }
    }
    private void InteractWithOtherObjects()
    {
        if (canClick)
        {
            click = new InputAction(binding: "<Mouse>/leftButton");
            click.performed += ctx =>
            {
                RaycastHit hit;
                Vector3 coor = Mouse.current.position.ReadValue();
                //if (Physics.Raycast(_cam.ScreenPointToRay(_cam.transform.forward * interactionDistance), out hit)) 
                if (Physics.Raycast(_cam.transform.position, _cam.transform.forward * interactionDistance, out hit))
                {

                    hit.collider.GetComponent<IInteractable>()?.Interact();
                    StartCoroutine(LockMouseClick());
                    //print(hit.transform.gameObject.name);


                }
            };
            click.Enable();
        }
           
    }

    IEnumerator LockMouseClick()
    {
        canClick = false;
        yield return new WaitForSeconds(0.1f);
        canClick = true;
    }


}