using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(Stats))]
public class DamageOnHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats ourstats = GetComponent<Stats>();
        Stats hitstats = collision.gameObject.GetComponent<Stats>();

        if (hitstats != null)
        {
            hitstats.health -= ourstats.attack - hitstats.defense;

            if( hitstats.health <= 0)
            {
            }
        }
        
    }
}
