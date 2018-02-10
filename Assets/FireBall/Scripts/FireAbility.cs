using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAbility : MonoBehaviour
{

    [SerializeField]
    float rotAroundSpeed;

    [SerializeField]
    Transform aBall;
    [SerializeField]
    Transform bBall;
    [SerializeField]
    TrailRenderer aTrail;
    [SerializeField]
    TrailRenderer bTrail;

    [SerializeField]
    float frequency = 20.0f;
    [SerializeField]
    float magnitude = 0.5f;

    private void Start()
    {
       

    }

    void Update ()
    {
        /*aTrail.startWidth = aTrail.startWidth * transform.localScale.x;
        aTrail.endWidth = aTrail.endWidth * transform.localScale.x;
        bTrail.startWidth = bTrail.startWidth * transform.localScale.x;
        bTrail.endWidth = bTrail.endWidth * transform.localScale.x;
        aTrail.widthMultiplier = transform.localScale.x;
        bTrail.widthMultiplier = transform.localScale.x;*/

        aBall.RotateAround(transform.position, transform.up, rotAroundSpeed * Time.deltaTime);
        bBall.RotateAround(transform.position, transform.up, rotAroundSpeed * Time.deltaTime);

        aBall.localPosition = aBall.localPosition + Vector3.up * Mathf.Sin(Time.time * frequency) * magnitude;
        bBall.localPosition = bBall.localPosition + Vector3.up * Mathf.Sin(Time.time * frequency) * magnitude;

        /*for(int i = 0; i < aTrail.positionCount; i++)
        {
            Vector3 p = aTrail.GetPosition(i) + transform.position;
           // aTrail.

        }*/
    }

}
