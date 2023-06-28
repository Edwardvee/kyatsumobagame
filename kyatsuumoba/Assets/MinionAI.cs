using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionAI : MonoBehaviour
{
    public Vector3 destination;
    public Vector3 finalDestination;


    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(destination);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.transform.position.x >= 19 && this.transform.position.z <= -26){ 
    agent.SetDestination(finalDestination);
            }
        if (this.transform.position.x <= -34 && this.transform.position.z >= 26)
        {
            agent.SetDestination(finalDestination);
        }
    }
}
