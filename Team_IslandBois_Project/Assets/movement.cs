using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour{
    
    private Game g;
    
    // Start is called before the first frame update
    void Start(){
        g = GameObject.FindWithTag("GameController").GetComponent<Game>();
    }

    // Update is called once per frame
    void Update(){
        float speed = g.getSpeed();
        transform.position += Vector3.left * (speed * Time.deltaTime);
    }

}
