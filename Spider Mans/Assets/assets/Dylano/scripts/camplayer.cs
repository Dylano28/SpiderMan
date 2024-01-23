using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Camera playerCamera;
    public float rotationSpeed = 5f;

    void Update()
    {
        /*
        // Check if the camera reference is assigned
        if (playerCamera == null)
        {
            Debug.LogError("aaaaaaaaaaaaaaa my neck");
            return;
        }

        // Get the horizontal input for rotation
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the new rotation angle based on the camera's forward direction
        Vector3 cameraForward = Vector3.Scale(playerCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = horizontalInput * cameraForward;

        // Calculate the rotation based on the move direction
        if (moveDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }
        */

        var rot = playerCamera.transform.rotation;
        transform.rotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, rot.eulerAngles.y, rot.eulerAngles.z));
    }
}
