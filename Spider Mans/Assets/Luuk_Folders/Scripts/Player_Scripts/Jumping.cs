using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    [SerializeField] private float jumpHeight;
    private int JumpTime = 1;

    public bool CanJump = true;

    private Rigidbody myRigidbody;


    private void Awake()
    {
        myRigidbody= GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && CanJump)
        {
            myRigidbody.velocity = Vector3.up * jumpHeight;
            CanJump = false;
            StartCoroutine(JumpRoutine());
        }
    }

    IEnumerator JumpRoutine()
    {
        yield return new WaitForSeconds(JumpTime);
        CanJump = true;
    }
}
