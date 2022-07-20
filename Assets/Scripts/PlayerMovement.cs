using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D myrigidBody2D;
    public float jumpspeed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myrigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidBody2D.velocity = new Vector2(speed, myrigidBody2D.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myrigidBody2D.velocity = new Vector2(myrigidBody2D.velocity.x, jumpspeed);
        }
    }

    //effected by touching in obstacle which had been tag button
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

            SceneManager.LoadScene(0);
        }
    }

    
}
