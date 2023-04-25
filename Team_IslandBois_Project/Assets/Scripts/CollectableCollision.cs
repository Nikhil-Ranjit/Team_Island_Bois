using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCollision : MonoBehaviour{
    
    public int number = 0;
    
    private Game g;
    
    // Start is called before the first frame update
    void Start()
    {
        g = GameObject.FindWithTag("GameController").GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col){
        Debug.Log("collision");
        if (col.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            g.collect(number);
        }
    }
}
