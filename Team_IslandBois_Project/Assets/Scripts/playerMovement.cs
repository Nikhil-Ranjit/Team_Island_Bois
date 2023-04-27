using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour{

    public float speed;
    public Screens screensScript;
    private bool isAlive = true;
    float timer = 0;

    // Start is called before the first frame update
    void Start(){
        transform.position = new Vector3(-8.5f, 0, 0);
        screensScript = GameObject.FindGameObjectWithTag("sc").GetComponent<Screens>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3.75)
            {
                transform.position += Vector3.up * (speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3.75)
            {
                transform.position += Vector3.down * (speed * Time.deltaTime);
            }
        }
        if (timer < 5)
        {
            timer += Time.deltaTime;
        }
        else
        {
            screensScript.setStartScreen();
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("collision");
        GetComponent<SpriteRenderer>().enabled = false;
        screensScript.setGameOverScreen();
        isAlive = false;
        }
    }


