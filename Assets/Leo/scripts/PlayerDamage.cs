using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

     public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Stats hitstats = collision.gameObject.GetComponent<Stats>();

        if (hitstats != null && collision.CompareTag("enemy"))
        {
            hitstats.health -= damage - hitstats.defense;
            Destroy(this.gameObject);
        }
    }
}
