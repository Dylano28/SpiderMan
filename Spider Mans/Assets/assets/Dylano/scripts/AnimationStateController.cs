using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Getting the animator component we want to use.
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("walk", Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") != 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("jump");
        }

        if (Input.GetKeyDown("w"))
        {
            anim.Play("walk");
        }
        else if (Input.GetKeyDown("a"))
        {
            anim.Play("walk");
        }
        else if (Input.GetKeyDown("d"))
        {
            anim.Play("walk");
        }
        else if (Input.GetKeyDown("s"))
        {
            anim.Play("walk");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("run");
        }
    }
}
