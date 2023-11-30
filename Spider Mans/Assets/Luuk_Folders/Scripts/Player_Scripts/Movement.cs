using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject targetCam;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        MoveForward();
        RotatePlayer();
    }

    private void MoveForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
    }

    private void RotatePlayer()
    {
        Quaternion startRot;
        startRot = transform.rotation;

        if(Input.GetAxisRaw("Mouse X") > startRot.x)
        {
            //new Vector3(Input.GetAxisRaw("Mouse X"),0,0) = targetCam.transform.rotation;
        }
    }
}