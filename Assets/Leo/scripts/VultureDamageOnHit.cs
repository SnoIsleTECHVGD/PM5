using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureDamageOnHit : MonoBehaviour
{
    public float damage;
    private bool isParent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        VultureStats hitstats = collision.gameObject.GetComponent<VultureStats>();

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
