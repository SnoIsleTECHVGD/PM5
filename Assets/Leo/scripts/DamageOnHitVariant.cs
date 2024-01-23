using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHitVariant : MonoBehaviour
{

    public float damage;
    private bool isParent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats hitstats = collision.gameObject.GetComponent<Stats>();

        if (hitstats != null)
        {
            hitstats.health -= damage - hitstats.defense;

            if (hitstats.health <= 0)
            {
                Destroy(hitstats.gameObject);
            }
        }

    }
}
