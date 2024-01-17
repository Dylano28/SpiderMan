using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int IsWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("walk");
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool(IsWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        if (!IsWalking && forwardPressed)
        {
            animator.SetBool("walk", true);
        }
        if (IsWalking && !forwardPressed)
        {
            animator.SetBool(IsWalkingHash, false);
        }



    }
}
