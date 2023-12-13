using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageOnHit : MonoBehaviour
{
    public float damage;
    private bool isParent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Stats hitstats = collision.gameObject.GetComponent<Stats>();

        if (hitstats != null)
        {
            hitstats.health -= damage - hitstats.defense;

            if( hitstats.health <= 0)
            {
                Destroy(hitstats.gameObject);
            }
        }
        
    }

    private void Update()
    {
        if(transform.parent.name=="PLAYER")
        {
            isParent = true;
        }
        
        
   
        
        if(isParent == true)
        {
            damage = 0;
        }
    }
}
