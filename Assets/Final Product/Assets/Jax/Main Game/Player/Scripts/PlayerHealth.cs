using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Header("PlayerHealth")]
    [SerializeField] public float startingHealth;

    public HealthBar healthBar;
    public float maxHealth = 100f;
    public float currentHealth;
    public SpriteRenderer player;
    private Animator anim;
    private bool dead;
    private Transform currentCheckpoint;
    [Header("Components")]
    [SerializeField] private Behaviour[] components;
    private bool invulerable;
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
            Respawn();
        }
    }

    public IEnumerator FlashRed()
    {
        player.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        player.color = Color.white;
    }

    public void Respawn()
    {
        dead = false;
        AddHealth(maxHealth);
        anim.Play("TinTomIdle2");


        foreach (Behaviour component in components)
            component.enabled = true;
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, maxHealth);
    }



}