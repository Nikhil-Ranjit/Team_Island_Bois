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
        text1.CrossFadeAlpha(0, 7, true);
        text2.CrossFadeAlpha(0, 7, true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void setGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

}
