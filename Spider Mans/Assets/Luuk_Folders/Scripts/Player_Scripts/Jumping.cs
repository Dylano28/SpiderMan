using System.Collections;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public bool grounded = false;
    [SerializeField] private float jumpHeight;
    private int JumpTime = 1;

    public bool CanJump = true;

    private Rigidbody myRigidbody;


    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
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
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * 3, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;  
    }

    IEnumerator JumpRoutine()
    {
        yield return new WaitForSeconds(JumpTime);
        //CanJump = true;
    }
}
