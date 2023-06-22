using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{


    public NavMeshAgent agent;
    public float rotateSpeedMovement = 0.075f;
    public float rotateVelocity;
    private HeroCombat heroCombatScript;

    // Start is called before the first frame update
    void Start()
    {
        
        agent = gameObject.GetComponent<NavMeshAgent>();
        heroCombatScript = gameObject.GetComponent<HeroCombat>();
    }

    // Update is called once per frame
    void Update()
    {
        if (heroCombatScript.targetedEnemy != null) {
            if (heroCombatScript.targetedEnemy.GetComponent<HeroCombat>().isHeroAlive) {
                heroCombatScript.targetedEnemy = null;
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Floor") {
                    agent.SetDestination(hit.point);

                    Quaternion rotationToLookAt = Quaternion.LookRotation(hit.point - transform.position);
                    float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotationToLookAt.eulerAngles.y, ref rotateVelocity, rotateSpeedMovement * (Time.deltaTime * 5));

                    transform.eulerAngles = new Vector3(0, rotationY, 0);

                }

            }
        }
    }
}
