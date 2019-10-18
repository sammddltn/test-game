using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public GameObject PositionA; 
    public GameObject PositionB; 
    public NavMeshAgent agent;

    public bool direction;
    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(PositionA.transform.position);
        direction = false;

    }

    // Update is called once per frame
    void Update()
    {

        if ( !direction && agent.remainingDistance < 0.1 ) {
            agent.SetDestination(PositionB.transform.position);
            direction = true;
        }

        if ( direction && agent.remainingDistance < 0.1 ) {
            agent.SetDestination(PositionA.transform.position);
            direction = false;
        }

    }
}
