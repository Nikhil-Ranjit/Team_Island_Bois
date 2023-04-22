using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class Game : MonoBehaviour{

    public GameObject[] collectables;
    public int collectableSpawnPct;

    public GameObject[] obstacles;

    public float speed = 5;

    public float minSpawnTime = 1;
    public float maxSpawnTime = 4;
    
    private bool[] collected;

    private double timer;
    private double waitTime;

    // Start is called before the first frame update
    void Start(){
        collected = new bool[5];
        waitTime = 1;
    }

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;
        if (timer > waitTime){
            timer -= waitTime;
            waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            spawn();
        }
    }

    void spawn(){
        if (Random.Range(0f, 100f) < collectableSpawnPct){
            //spawn collectable
            int obj = Random.Range(0, collectables.Length - 1);
            float pos = Random.Range(-4f, 4f);
            GameObject clone = Instantiate(collectables[obj], new Vector3(pos, 6, 0), transform.rotation);
            Destroy(clone, 2);
        } else{
            //spawn obstacle
            int obj = Random.Range(0, obstacles.Length - 1);
            float pos = Random.Range(-4f, 4f);
            GameObject clone = Instantiate(obstacles[obj], new Vector3(pos, 6, 0), transform.rotation);
            Destroy(clone, 2);
        }
    }

    public float getSpeed(){
        return speed;
    }

    public void collect(int i){
        collected[i] = true;
    }
}
