using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

     public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CactiStats hitstats = collision.gameObject.GetComponent<CactiStats>();

        if (hitstats != null && collision.CompareTag("enemy"))
        {
            hitstats.health -= damage - hitstats.defense;
        }
    }
}
