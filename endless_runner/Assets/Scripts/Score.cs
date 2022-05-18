using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreUI;

  

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
        Debug.Log("The score is" + score);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collider is working" );

        if (other.gameObject.tag == "scorebox")
        {
            score++;
        }
    }

}
