using UnityEngine;

public class CameraCon : MonoBehaviour
{
    [SerializeField] Transform camTarget;
    [SerializeField] float pLerp = 0.2f;
    [SerializeField] float rLerp = 0.2f;
    private void RotatePlayer()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }
}
