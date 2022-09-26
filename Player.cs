using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKey("up"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + (speed * Time.deltaTime));
        }

        if (Input.GetKey("down"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - (speed * Time.deltaTime));
        }

        if (Input.GetKey("left"))
        {
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
        }

        if (Input.GetKey("right"))
        {
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }
    }
}
