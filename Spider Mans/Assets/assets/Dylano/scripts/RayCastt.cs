using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class RayCastt : MonoBehaviour

{
public float Range = 100f;
public LayerMask LayerOfObjectTheRopeCanAttachTo;
    public QueryTriggerInteraction DoYouWantToAttachToTrigger;
    public float ForceMagnitude = 100f;
    public ForceMode TypeOfForceMode;
    private Transform anchorTransform;
    private bool webAttached;
    private Rigidbody rigidbodyRef;

    private void Start()
    {
        this.rigidbodyRef = GetComponent<Rigidbody>();
    }

    public void FireWebTowardsTarget(Vector3 origin, Vector3 Direction)

    {   Ray rayshoot = new Ray(origin, Direction);
        
        RaycastHit hitinfo;

        if(Physics.Raycast(rayshoot, this.Range, this.LayerOfObjectTheRopeCanAttachTo, this.DoYouWantToAttachToTrigger ))
        {
            Physics.Raycast(rayshoot, out hitinfo);

            anchorTransform = new GameObject("Anchor").transform;
            this.anchorTransform.position = hitinfo.point;
            this.anchorTransform.parent = hitinfo.transform;

            this.webAttached = true;
        }
    }

    public void DetachWeb()
    {
        Destroy(this.anchorTransform.gameObject);
        this.webAttached = false;
    }

    private void Update()
    {
        if(webAttached)
        {
            var directionTowardsAnchor = (this.anchorTransform.position - gameObject.transform.position).normalized;
            this.rigidbodyRef.AddForce(directionTowardsAnchor, this.TypeOfForceMode );
        }
    }

}
