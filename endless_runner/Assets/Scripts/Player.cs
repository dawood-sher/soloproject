using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 500f;
    public float directionalSpeed=20f;
    public AudioClip scoreUP;
    public AudioClip damage;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    //Fixed  Update is called once per frame
    void FixedUpdate()
    {
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal);
        transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3 (Mathf.Clamp(gameObject.transform.position.x + moveHorizontal, -2.5f, 2.5f), gameObject.transform.position.y, gameObject.transform.position.z), directionalSpeed * Time.deltaTime);
#endif      
        GetComponent<Rigidbody>().velocity = Vector3.forward * playerSpeed * Time.deltaTime;

        // mobile controls

        Vector2 horizontaltouch = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f));

        if (Input.touchCount > 0)
        {
            transform.position = new Vector3(horizontaltouch.x, transform.position.y, transform.position.z);
        }




    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collider is working");

        if (other.gameObject.tag == "scorebox")
        {
            GetComponent<AudioSource>().PlayOneShot(scoreUP, 1.0f);
        }
        if (other.gameObject.tag == "obstacle")
        {
            GetComponent<AudioSource>().PlayOneShot(damage, 1.0f);
        }
    }



}
