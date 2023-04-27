using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Screens : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public GameObject gameOverScreen;
    public GameObject startScreen;

    public void Start()
    {

    }

    public void setStartScreen()
    {
        startScreen.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        playerMovement.isAlive = true;
        GameObject.FindWithTag("GameController").GetComponent<Game>().resetSpeed();
    }

    public void setGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

}
