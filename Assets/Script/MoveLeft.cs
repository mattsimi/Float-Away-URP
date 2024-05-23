using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed;

    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //limit of materials
        transform.position = new Vector2(
            transform.position.x - speed * Time.deltaTime,
            transform.position.y);

       
    }
}
