using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spr : MonoBehaviour
{
    public bool ismoving = false;
    public float movementspeedsprint = 200;
    public float movementspeed = 200;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            ismoving= true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            ismoving= false;
        }
       
        if (Input.GetKey(KeyCode.LeftControl) & ismoving == true)
        {
            transform.position += transform.forward * Time.deltaTime * movementspeedsprint;
        }
    }
}
