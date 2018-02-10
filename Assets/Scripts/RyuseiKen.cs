using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RyuseiKen : MonoBehaviour
{

    Rigidbody rb;

    float hitForce;

    [SerializeField]
    GameObject hitExplosion;

    [SerializeField]
    float lifeTime;

    IEnumerator endHitCurutine;
    //IEnumerator particleDestroyer;

    [SerializeField]
    ParticleSystem ps;

    public float HitForce
    {
        get
        {
            return hitForce;
        }

        set
        {
            hitForce = value;
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        endHitCurutine = EndHit(lifeTime);
        //particleDestroyer = DestroyParticle(2.0f);
        rb.AddForce(Vector3.forward * HitForce, ForceMode.Impulse);
        StartCoroutine(endHitCurutine);
        //Invoke("EndHit", lifeTime);
    }

    IEnumerator EndHit(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        hitExplosion.SetActive(true);
        rb.velocity = Vector3.zero;
        //StartCoroutine(particleDestroyer);
        Destroy(gameObject,ps.startLifetime);
        StopCoroutine(endHitCurutine);
    }

    /*IEnumerator DestroyParticle(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
        StopCoroutine(particleDestroyer);
    }*/
}
