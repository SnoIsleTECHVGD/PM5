using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaxPlayerRespawn : MonoBehaviour
{
    private Transform currentCheckpoint;
    private PlayerHealth pHealth;

    private void Awake()
    {
        pHealth = GetComponent<PlayerHealth>();
    }


    public void CheckpointRespawn()
    {
        transform.position = currentCheckpoint.position;
        pHealth.Respawn();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform;

            collision.GetComponent<Collider2D>().enabled = true;
        }

    }
}
