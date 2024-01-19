using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaxStats : MonoBehaviour
{
    public float health;
    public float defense;
    public float attack;

    public GameObject loseText;

    private void Update()
    {
        if (health <= 0)
        {

            gameObject.SetActive(false);
        }



    }
}