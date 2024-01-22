using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBar;
    public float maxHealth = 100f;
    public float currentHealth;
    public SpriteRenderer player;
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(10);
        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        StartCoroutine(FlashRed());

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

    public IEnumerator FlashRed()
    {
        player.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        player.color = Color.white;
    }
}