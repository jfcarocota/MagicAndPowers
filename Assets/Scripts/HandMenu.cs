using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenu : MonoBehaviour {

    [SerializeField]
    float checkDelay;
    [SerializeField]
    float menuActivationRange;

    Coroutine menuActivation;
    [SerializeField]
    GameObject menu;

    private void Start()
    {
        StartCoroutine(CheckActivation(checkDelay));
    }

    IEnumerator CheckActivation(float waitTime)
    {
        while (true)
        {
            menu.SetActive(transform.localRotation.z >= menuActivationRange);
            Debug.Log(transform.localRotation);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
