using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigersRayCasting : MonoBehaviour {
    //Raycasting line.

    [SerializeField, Range(0f, 100f)] //sirve para mostrar algo privado en el inspector.
    float rayDistance;
    [SerializeField]
    LayerMask hitLayer;
    [SerializeField]
    Color rayColor = Color.green;
    RaycastHit hit;

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, hitLayer))
        {
            if (hit.collider)
            {
                Debug.Log("Ouch, me dolio");
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
    }
}
