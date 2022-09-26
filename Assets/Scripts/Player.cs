using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed;
    bool touchingPlatform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 2;
      
    }

    // Update is called once per frame
    void Update()
    {
        ReadKeys();
    }

    void ReadKeys()

    {
        //rb.velocity = new Vector2(0, 0);

        if (Input.GetKeyDown("up") && touchingPlatform == true)
        {
            print("player pressed up");
            //transform.position = new Vector2(transform.position.x, transform.position.y + (6 * Time.deltaTime));
            rb.velocity = new Vector2(0, 10);
        }

        if (Input.GetKeyDown("down"))
        {
            print("player pressed down");
            //transform.position = new Vector2(transform.position.x, transform.position.y - (5 * Time.deltaTime));
            rb.velocity = new Vector2(0, -5);
        }

        if (Input.GetKey("left"))
        {
            print("player pressed left");
            //transform.position = new Vector2(transform.position.x - (7 * Time.deltaTime), transform.position.y);
            rb.velocity = new Vector2(-4, 0);
        }

        if (Input.GetKey("right"))
        {
            print("player pressed right");
            //transform.position = new Vector2(transform.position.x + (10 * Time.deltaTime), transform.position.y);
            rb.velocity = new Vector2(6, 0);
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = false;
        }
    }
}
