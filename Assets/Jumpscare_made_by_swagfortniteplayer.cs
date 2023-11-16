using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_made_by_swagfortniteplayer : MonoBehaviour
{

    public GameObject jeffscare;


    private void OnTriggerEnter(Collider other)
    {
   jeffscare.SetActive(true);
    }

}

