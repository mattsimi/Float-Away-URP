using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour
{
    public float leftLimit;

    // Update is called once per frame
    void Update()
    //destruction of column after exceeding limit
    {
         if (transform.position.x <= leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
