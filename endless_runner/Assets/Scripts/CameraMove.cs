using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;


    private void LateUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position , new Vector3 (0, gameObject.transform.position.y,player.gameObject.transform.position.z-2), Time.deltaTime);
    }
}
