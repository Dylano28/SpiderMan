using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Camera playerCamera;
    public float rotationSpeed = 5f;

    void Update()
    {
        

        var rot = playerCamera.transform.rotation;
        transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, rot.eulerAngles.y, rot.eulerAngles.z));
    }
}
