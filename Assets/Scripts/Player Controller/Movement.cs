using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform camTransform;

    [SerializeField] private float speed;

    private Vector3 unitVectorAxisX;
    private Vector3 unitVectorAxisY;
    private Vector3 unitVectorAxisZ;
    private void Start()
    {
        unitVectorAxisX = new Vector3(speed, 0, 0);
        unitVectorAxisY = new Vector3(0, speed, 0);
        unitVectorAxisZ = new Vector3(0, 0, speed);
    }
    private void Update()
    {
        float currentRotation = camTransform.rotation.eulerAngles.normalized.z;

        Vector3 currentPosition = camTransform.position;

        Vector3 neededRotationVector = new Vector3(0, 0, currentRotation * speed);
        Vector3 newPosition = neededRotationVector + currentPosition;

        if (Input.GetKey(KeyCode.W) == true)
        {
            camTransform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            camTransform.position = - newPosition;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            camTransform.position -= unitVectorAxisX;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            camTransform.position += unitVectorAxisX;
        }
    }
}
