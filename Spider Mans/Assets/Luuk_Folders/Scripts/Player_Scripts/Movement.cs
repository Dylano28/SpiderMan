using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Camera targetCam;
    Vector2 turn;

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
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -targetCam.transform.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += targetCam.transform.right * moveSpeed * Time.deltaTime;
        }
    }

    private void RotatePlayer()
    {
        //turn.x += Input.GetAxisRaw("Mouse X");
       // turn.y += Input.GetAxisRaw("Mouse Y");
       // transform.localRotation = Quaternion.Euler(turn.y * 2, turn.x, 0);

    }
}
