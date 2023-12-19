using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject targetGameObject;
    // Start is called before the first frame update
    void Start()
    {
        var mechanic = this.GetComponent<RayCastt>();
        var dir = (this.targetGameObject.transform.position - gameObject.transform.position).normalized;
        mechanic.FireWebTowardsTarget(gameObject.transform.position, dir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
