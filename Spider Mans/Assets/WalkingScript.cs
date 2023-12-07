using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] public float jumpPower = 3f;
    [SerializeField] public float movementSpeed = 25f;
    [SerializeField] public float rotSpeed = 125f;
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
       
       
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
        transform.Rotate(Vector3.down * -rotSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}