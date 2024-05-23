using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{

public float speed;
Rigidbody2D rb;

//References
public Score scoreText;
public GameObject replayBtn;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        //Fish flap 
        rb.velocity = Vector2.up*speed; 
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Column"))
        {
            //if fish passes through column + points to user
           print("Score Up");
           scoreText.ScoreUp();
        }
        else if (collision.CompareTag("PowerUp"))
        {
            //collection of powerup additional points
           print("Score Up");
           scoreText.ScoreMul();
        }
    }
    //collision with obsticles
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground") ||
        collision.gameObject.CompareTag("Pipe")||
        collision.gameObject.CompareTag("Circle"))
        {
            //game over
            Time.timeScale = 0;
            replayBtn.SetActive(true);
        }
    }
    //restart button
    public void ReplayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
