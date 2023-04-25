using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    public Screens screensScript;
    // Start is called before the first frame update
    void Start()
    {
        screensScript = GameObject.FindGameObjectWithTag("sc").GetComponent<Screens>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col){
        Debug.Log("collision");
        if (col.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            screensScript.setGameOverScreen();
        }
    }
}
