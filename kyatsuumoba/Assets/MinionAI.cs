using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionAI : MonoBehaviour
{
    public Vector3 destination;
    public Vector3 finalDestination;
    public bool isBlue;

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        if (isBlue) {
            this.gameObject.layer = 9;
        }
        else
        {
            this.gameObject.layer = 10;
        }
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
