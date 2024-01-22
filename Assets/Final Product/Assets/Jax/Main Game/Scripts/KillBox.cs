using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public GameObject Player;
    Rigidbody2D playerRB2D;

    private void Start()
    {
        playerRB2D = Player.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerRB2D.gravityScale = 0;
            playerRB2D.velocity = Vector2.zero;
        }
    }
}