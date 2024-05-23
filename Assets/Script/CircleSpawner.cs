using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleSpawner : MonoBehaviour
{
    //inputs
    public GameObject circlePrefab;
    public float minY, maxY;
    float timer;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        //spawning of shark
        //spawn a column
        SpawnCircle();
    }

    // Update is called once per frame
    void Update()
    {
        //time of sharek spawning
        timer+= Time.deltaTime;
        if(timer >=maxTime)
        {
            SpawnCircle();
            timer = 1;
        }
        //spawn circle every x ammounts of seconds
    }

    void SpawnCircle(){
        //randomness of position of sapwning
        float randYPos = Random.Range(minY, maxY);

        GameObject newCircle = Instantiate (circlePrefab);
        newCircle.transform.position = new Vector2(
            transform.position.x,
            randYPos);
         
    }
}