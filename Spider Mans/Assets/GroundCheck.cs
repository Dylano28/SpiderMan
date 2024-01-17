using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask gcl;
    GameObject GroundCheckObj;
    public bool isGrounded;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoGroundCheck();
    }

    private bool DoGroundCheck()
    {
         isGrounded = Physics.CheckSphere(GroundCheckObj.transform.position, 0.1f, gcl); 

        return isGrounded;
    }
}
