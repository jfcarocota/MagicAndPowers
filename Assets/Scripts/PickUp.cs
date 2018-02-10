using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    [SerializeField]
    float friction;
    [SerializeField]
    float rayDistance;
    RaycastHit hit;
    [SerializeField]
    LayerMask hitLayer;
    Rigidbody rb;
    [SerializeField]
    Color rayColor = Color.yellow;
    FixedJoint joint;

    private void Awake()
    {
        joint = GetComponent<FixedJoint>();
    }


    private void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, hitLayer))
        {
            if (hit.collider)
            {
                if (!joint.connectedBody)
                {
                    rb = hit.transform.GetComponent<Rigidbody>();
                    joint.connectedBody = rb;
                }
                //rb.AddForce(hit.normal * friction, ForceMode.Impulse);
            }
        }else if (joint)
        {
            //joint = null;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
    }
}
