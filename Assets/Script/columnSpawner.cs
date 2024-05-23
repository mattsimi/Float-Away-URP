using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;
    public float minY, maxY;
    float timer;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        //spawn a column
        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        //spawning column
        timer+= Time.deltaTime;
        if(timer >=maxTime)
        {
            SpawnColumn();
            timer = 0;
        }
        //spawn columns every x ammounts of seconds
    }

    void SpawnColumn(){
        //randomness of spawning of position
        float randYPos = Random.Range(minY, maxY);

        GameObject newColumn = Instantiate (columnPrefab);
        newColumn.transform.position = new Vector2(
            transform.position.x,
            randYPos);
         
    }
}
