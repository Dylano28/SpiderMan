using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WebZip : MonoBehaviour
{
    [SerializeField] private float webStrike;
    [SerializeField] private GameObject myPlayer;

    private Rigidbody myRigidBody;

    private void Awake()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        WebZiping();
    }

    private void WebZiping()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            myRigidBody.velocity = Vector3.zero;
            myRigidBody.AddForce(myPlayer.transform.forward * (webStrike));
        }
    }
}
    
 
