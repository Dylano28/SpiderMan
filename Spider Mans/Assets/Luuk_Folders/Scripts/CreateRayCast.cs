using UnityEngine;

public class CreateRayCast : MonoBehaviour
{
    [SerializeField] float distance = 10f;
    [SerializeField] float swingSpeed = 10f;

    private Transform currentBuilding;

    void Update()
    {
        GameObject[] buildings = GameObject.FindGameObjectsWithTag("Building");

        currentBuilding = buildings[0].transform;

        Vector3 dir = currentBuilding.transform.position - transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Physics.Raycast(transform.position, dir, distance))
            {
                transform.position += dir * swingSpeed * Time.deltaTime;
            }
        }
        Debug.DrawRay(transform.position, dir, Color.red);
    }

}
