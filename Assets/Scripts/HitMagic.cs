using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMagic : MonoBehaviour
{
    RyuseiKen ryuseiken;
    [SerializeField]
    GameObject castObj;
    [SerializeField]
    Transform castPoint;

    Rigidbody rb;

    [SerializeField]
    float castForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(rb.velocity.z >= castForce)
        {
            GameObject obj = (GameObject)Instantiate(castObj, castPoint.position, castPoint.rotation);
            ryuseiken = obj.GetComponent<RyuseiKen>();
            ryuseiken.HitForce = rb.velocity.z;
        }
    }
}
