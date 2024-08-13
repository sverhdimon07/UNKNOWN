using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRestriction : MonoBehaviour
{
    [SerializeField] private Transform objTransform;
    [SerializeField] private Transform camTransform;
    private void Update()
    {
        Vector3 currentRotation = objTransform.rotation.eulerAngles;
        Vector3 currentPosition = objTransform.position;

        objTransform.rotation = Quaternion.Euler(0, 0, 0);

        objTransform.position = camTransform.position;
    }
}
