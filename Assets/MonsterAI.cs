using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public Transform[] waypoints;

    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        GoToWaypoint();    
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            GetComponent<NavMeshAgent>().SetDestination(player.position);
        }
        else if (GetComponent<NavMeshAgent>().remainingDistance < 1f)
        {
            GoToWaypoint();
        }

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player = null;
        }
    }

    void GoToWaypoint() 
    {
        GetComponent<NavMeshAgent>().SetDestination(waypoints[Random.Range(0, waypoints.Length)].position);
    }

}
