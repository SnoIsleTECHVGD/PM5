using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    

    [Header("Health")]
    [SerializeField] public float startingHealth;
    public float currentHealth {  get; private set; }
    private Animator anim;
    private bool dead;
    [Header("Components")]
    [SerializeField] private Behaviour[] components;
    private bool invulerable;

    public float health;
    public float defense;
    public float attack;

    public GameObject loseText;

    public void Awake()
    {
        currentHealth = startingHealth;
        
    }

    public void Respawn()
    {
        dead = false;
        AddHealth(startingHealth);
        anim.Play("TinTomIdle2");
        
        foreach(Behaviour component in components)
            component.enabled = true;

         
   }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }



    private void Update()
    {
        if (health <= 0)
        {

            gameObject.SetActive(false);
        }



    }
}
