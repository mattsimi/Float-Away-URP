using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Score scoreText;

    // Start is called before the first frame update
   
    // Update is called once per frame   
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
 {
    }

    //powerup collection distruction 
private void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.CompareTag("PowerUp")){
         Destroy(other.gameObject);
       
    }

}


}
