using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplyShader : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject inGameMMenu;
    public GameObject gameOverUI;
    public GameObject player;

    private void Awake()
    {
        Shader.SetGlobalFloat("_Curvature", 2.0f);
        Shader.SetGlobalFloat("_Trimming", 0.1f);

        

    }


    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        MainMenu.gameObject.SetActive(true);
        inGameMMenu.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        StartCoroutine(StartGame(0.1f));
    }

      public void PauseGame()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        MainMenu.gameObject.SetActive(true);
        inGameMMenu.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        MainMenu.gameObject.SetActive(false);
        inGameMMenu.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(true);
    }

    IEnumerator StartGame(float waitTime)
    {
        
        MainMenu.gameObject.SetActive(false);
        inGameMMenu.gameObject.SetActive(true);
        gameOverUI.gameObject.SetActive(false);
        yield return new WaitForSeconds(waitTime);
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
    }

}
