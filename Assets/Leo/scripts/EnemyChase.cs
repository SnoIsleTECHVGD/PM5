using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class EnemyChase : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public Transform target;
    public float followDistance;
    public float minFollowDistance;
    public float speed;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);
        Vector2 direction = target.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //if the position of the target and the position of the player is less than the public follow distance,
        if (Vector2.Distance(target.position, transform.position) < followDistance && Vector2.Distance(target.position, transform.position) > minFollowDistance)
        {
            // then using the physics (rigidbody) velocity, the enemy will move towards the target
            rb2D.velocity = (target.position - transform.position).normalized * speed;

            transform.rotation = Quaternion.Euler(Vector3.forward * angle);



            if (GetComponent<Rigidbody2D>().velocity.x < 0)
            {

                transform.Rotate(180f, 0f, 0);
                GetComponent<SpriteRenderer>().flipX = true;

            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

            if (GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                transform.Rotate(0f, 0f, 0);
                GetComponent<SpriteRenderer>().flipX = true;
            }

            if (GetComponent<Rigidbody2D>().velocity.x == 0)
            {
                transform.Rotate(0f, 0f, 0f);
                GetComponent<SpriteRenderer>().flipX = true;
            }



        }

    }
}
