using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health;
    private int currentHealth;

    public void TakeDamage(int damage)
    {
        currentHealth = Health -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {

        GetComponent<Collider2D>().enabled = false;

        this.enabled = false;
    }
}