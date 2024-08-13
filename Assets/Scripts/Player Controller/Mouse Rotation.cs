using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [SerializeField] private Transform camTransform;

    private Vector3 mousePosition;
    private void Start()
    {
        mousePosition = new Vector3(0, 0, 0);
    }
    private void Update()
    {
        if (mousePosition != Input.mousePosition)
        {
            mousePosition = Input.mousePosition;

            float mouseRotationAxisX = 0 - Input.mousePosition.y;
            float mouseRotationAxisY = 0 + Input.mousePosition.x;
            float mouseRotationAxisZ = 0 + Input.mousePosition.z;

            Quaternion mouseRotation = Quaternion.Euler(mouseRotationAxisX, mouseRotationAxisY, mouseRotationAxisZ);

            camTransform.rotation = mouseRotation;
        }
    }
}
