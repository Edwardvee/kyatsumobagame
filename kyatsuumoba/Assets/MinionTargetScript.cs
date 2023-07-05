using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionTargetScript : MonoBehaviour
{

    public List<GameObject> targetList = new List<GameObject> { };
    public MinionAI minionAIScript;
    public bool isBlue;
    // Start is called before the first frame update
    void Start()
    {
        minionAIScript = this.GetComponentInParent<MinionAI>();
        isBlue = minionAIScript.isBlue; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider) {

        if (isBlue)
        {
            if (!targetList.Contains(collider.gameObject) && collider.gameObject.layer == 10)
            {
                targetList.Add(collider.gameObject);
                Debug.Log("Objetivo anadido " + gameObject.name);
            }
        }
        else {

            if (!targetList.Contains(collider.gameObject) && collider.gameObject.layer == 9)
            {
                targetList.Add(collider.gameObject);

            }

        }
    }
    public void OnTriggerExit(Collider collider) {

        if (targetList.Contains(collider.gameObject)) { 
        targetList.Remove(collider.gameObject);
        }
    }
}
