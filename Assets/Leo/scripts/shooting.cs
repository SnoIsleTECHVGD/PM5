using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    private float x;
    public Rigidbody2D rb;
    public float speed;
    private bool moving = false;
    private Vector2 screenBounds;
    public object bulletPrefab;



    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

        x = transform.position.x;

        if (Input.GetMouseButtonDown(0) == true )
        {
            GetComponent<SpriteRenderer>().enabled = true;
            moving = true;
        }

        if (moving)
        {
            x = x + 3 * Time.deltaTime * speed;

        }
        transform.position = new Vector2(x, transform.position.y);


        
    }
}
