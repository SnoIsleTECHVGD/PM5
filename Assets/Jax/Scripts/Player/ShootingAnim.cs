using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAnim : MonoBehaviour
{

    private float x;
    public Rigidbody2D rb;
    public Animator player;
    public float speed;
    private bool moving = false;
    private Vector2 screenBounds;
    public object bulletPrefab;




    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();


        x = transform.position.x;
        
        if (Input.GetMouseButtonUp(0) == true)
        {
            Shoot();
            GetComponent<SpriteRenderer>().enabled = true;
            moving = true;
        }

        if (moving)
        {
            x = x + 7 * Time.deltaTime * speed;

            transform.position = new Vector2(x, transform.position.y);

        }


    }

    void Shoot()
    {
        GetComponent<Animator>().SetTrigger("Shoot");
    }
}
