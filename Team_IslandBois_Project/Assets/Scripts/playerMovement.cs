using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour{
    public float speed;

    // Start is called before the first frame update
    void Start(){
        transform.position = new Vector3(-8.0f, 0, 0);
    }

    // Update is called once per frame
    void Update()
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
}
