using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] obstaclesPrefabs;
    private Vector3 spawnObstaclePosition;

    

    // Update is called once per frame
    void Update()
    {

        float distancetoobstacle = Vector3.Distance(player.gameObject.transform.position, spawnObstaclePosition);

        if (distancetoobstacle < 120)
        {
            SpawnObstacles();
        }


    }


    void SpawnObstacles()
    {
        spawnObstaclePosition = new Vector3(0, 0, spawnObstaclePosition.z + 30);
        Instantiate(obstaclesPrefabs[(Random.Range(0, obstaclesPrefabs.Length))], spawnObstaclePosition, Quaternion.identity);
    }
}
