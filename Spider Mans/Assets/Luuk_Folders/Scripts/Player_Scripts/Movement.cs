using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Camera targetCam;
    Vector2 turn;
    Vector3 moveDirection;

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
            transform.position += targetCam.transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    private void RotatePlayer()
    {
        turn.x += Input.GetAxisRaw("Mouse X");
        turn.y += Input.GetAxisRaw("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + targetCam.transform.forward);
    }
    */
}