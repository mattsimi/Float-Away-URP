using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
   
[SerializeField] private float _speed = 1;
    // Update is called once per frame
    private void Update()
    //fish movement up, left and right
    {
       var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

       transform.Translate(dir*_speed*Time.deltaTime); 
    }
}
