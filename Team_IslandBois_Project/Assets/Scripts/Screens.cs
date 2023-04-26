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

    public void Start()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void setGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

}
