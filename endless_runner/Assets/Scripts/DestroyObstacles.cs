using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    private GameObject player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void Update()
    {
        if(gameObject.transform.position.z < player.transform.position.z - 15)
        {
            Destroy(gameObject);
        }
    }
}
