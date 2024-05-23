using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float leftLimit;
    Collider2D groundCollider;
    float groundLength;


    void Start()
    {
        //limit of ground
        groundCollider= GetComponent<Collider2D>();
        groundLength = groundCollider.bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //repruduction of ground
        if (transform.position.x <= leftLimit)
        {
            transform.position = new Vector2(
            transform.position.x + 2 * groundLength, transform.position.y);

        }
    }
}
