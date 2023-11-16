using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJumpscare : MonoBehaviour
{
    public bool once=false;
    public GameObject jumpscare;

    void OnTriggerEnter(Collider other)
    {
        jumpscare.SetActive(true);
        StartCoroutine(ScareDisable());
    }

    IEnumerator ScareDisable()
    {
        yield return new WaitForSeconds(3);
        jumpscare.SetActive(false);
        if (once)
        {
            Destroy(gameObject);
        }
    }

}

