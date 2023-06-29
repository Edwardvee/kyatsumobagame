using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject blueMinionPrefab;
    public GameObject redMinionPrefab;
    public Vector3 blueSpawnLocation = new Vector3 (120, 1, 123);   
    public Vector3 redSpawnLocation = new Vector3 (-120, 1, -115);
    public Vector3 topLaneLocation = new Vector3(110, 1, -105);
    public Vector3 botLaneLocation = new Vector3(-110, 1, 115);
    bool spawn = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            GameObject minionSpawned;
            //blueside
            minionSpawned = Instantiate(blueMinionPrefab, blueSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAI>().destination = redSpawnLocation;

            minionSpawned = Instantiate(blueMinionPrefab, blueSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAI>().destination = botLaneLocation;

            minionSpawned = Instantiate(blueMinionPrefab, blueSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAI>().destination = topLaneLocation;

            //redside
            minionSpawned = Instantiate(redMinionPrefab, redSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAI>().destination = blueSpawnLocation;

            minionSpawned = Instantiate(redMinionPrefab, redSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAI>().destination = botLaneLocation;

            minionSpawned = Instantiate(redMinionPrefab, redSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAI>().destination = topLaneLocation;

            spawn = false;
        }
    }
}
