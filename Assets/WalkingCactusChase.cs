using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingCactusChase : MonoBehaviour
{
    public Transform targert;
    public float speed;
    public float followDistance;
    private Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Vector2.Distance(targert.position, transform.position) < followDistance)
        {
            rb2D.velocity = (targert.position - transform.position).normalized;
        }




        if (GetComponent<Rigidbody2D>().velocity.x == 0)
        {
            GetComponent<Animator>().SetInteger("isChasing", 0);
        }


        if (GetComponent<Rigidbody2D>().velocity.x > 0 || GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            GetComponent<Animator>().SetInteger("isChasing", 1);
        }
    }
}
