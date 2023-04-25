using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;



public class Game : MonoBehaviour{

    public GameObject[] collectables;
    public int collectableSpawnPct;

    public GameObject[] obstacles;

    public float speed = 5;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 2;

    public float minCollectableSpawnTime;
    
    private bool[] collected;
    private double[] lastSpawn;

    private double timer;
    private double collectableTimer;
    private double waitTime;

    public Text instruct;
    public Text title;

    // Start is called before the first frame update
    void Start(){

        collected = new bool[collectables.Length];
        waitTime = 1;
        
    }

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;
        collectableTimer += Time.deltaTime;
        if (collectableTimer > minCollectableSpawnTime){
            collectableTimer = minCollectableSpawnTime + 1;
        }
        if (timer > waitTime){
            timer -= waitTime;
            waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            spawn();
        }
    }

    void spawn(){
        if (Random.Range(0f, 100f) < collectableSpawnPct && collectableTimer >= minCollectableSpawnTime){
            collectableTimer = 0;
            //spawn collectable
            int obj = Random.Range(0, collectables.Length);
            while(collected[obj]) obj = Random.Range(0, collectables.Length);
            float pos = Random.Range(-4f, 4f);
            GameObject clone = Instantiate(collectables[obj], new Vector3(12, pos, 0), transform.rotation);
            Destroy(clone, 5);
        } else{
            //spawn obstacle
            int obj = Random.Range(0, obstacles.Length);
            float pos = Random.Range(-4f, 4f);
            GameObject clone = Instantiate(obstacles[obj], new Vector3(12, pos, 0), transform.rotation);
            Destroy(clone, 5);
        }
    }

    public float getSpeed(){
        return speed;
    }

    public void collect(int i){
        collected[i] = true;

        for (int j = 0; j < collected.Length; j++){
            if (!collected[j]) return;
        }

        SceneManager.LoadScene("GameWon");
    }

   
}
