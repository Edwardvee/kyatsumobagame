using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //Stats
    public float speed;
    public float baseHealth;
    public float currentHealth;
    public float atkDmg;
    public float exp;
    public float expToLvlUp;

    public float magicDmg;
    public float armor;
    public float magicRes;
    public float atkSpeed;
    public int level;
    float health;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        currentHealth = baseHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")) { 
        levelUp();
        }

    }
    public void levelUp() {
        if (level < 15) { 
        level++;
        health = baseHealth + (150 * level / 30);
            speed = speed + 0.2f;
            agent.speed = speed;
            atkDmg = atkDmg + 2;
            baseHealth = health;
            currentHealth = currentHealth + (baseHealth / 15f);
            if (currentHealth > baseHealth) { 
            currentHealth = baseHealth; 
            }

            expToLvlUp = expToLvlUp + (50f * level / 5);
        Debug.Log("Level up");
        }
    }

}
