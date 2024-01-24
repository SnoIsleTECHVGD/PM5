using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHitVariant : MonoBehaviour
{

    public float damage;
    private bool isParent;
    public SpriteRenderer enemy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats hitstats = collision.gameObject.GetComponent<Stats>();

        if (hitstats != null)
        {


            FlashRed();
            hitstats.health -= damage - hitstats.defense;

            if (hitstats.health <= 0)
            {
                Destroy(hitstats.gameObject);
            }
        }


    }

    public IEnumerator FlashRed() 
    {
        enemy.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        enemy.color = Color.white;
    }
    
}
