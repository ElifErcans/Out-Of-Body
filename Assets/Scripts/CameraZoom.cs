using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    // public CinemachineVirtualCamera cam;
    // public float zoomMultiplier = 2;
    // public float defaultFov = 90;
    // public float zoomDuration = 2;
    //
    [SerializeField] CinemachineVirtualCamera vcam;
    private CinemachineComponentBase _componentBase;
    float cameraDistance;
    [SerializeField] float zoomSpeed = 1f;
    
    private void Update()
    {
        if (_componentBase == null)
        {
            //Debug.Log("Component Base is null");
            _componentBase = vcam.GetCinemachineComponent(CinemachineCore.Stage.Body);
        }
    
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            
            //Debug.Log("Scrolling");
            cameraDistance += Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
            cameraDistance = Mathf.Clamp(cameraDistance, 10, 40);
            vcam.m_Lens.FieldOfView = cameraDistance;
        }
    }
    
    // void Update()
    // {
    //     if (Input.GetMouseButton(1))
    //     {
    //         ZoomCamera(defaultFov / zoomMultiplier);
    //     }
    //     else if (cam.fieldOfView != defaultFov)
    //     {
    //         ZoomCamera(defaultFov);
    //     }
    // }
    // void ZoomCamera(float target)
    // {
    //     float angle = Mathf.Abs((defaultFov / zoomMultiplier) - defaultFov);
    //     cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, angle / zoomDuration * Time.deltaTime);
    // }
}