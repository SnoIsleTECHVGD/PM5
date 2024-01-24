using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureStats : Stats
{
    
    public Rigidbody2D rb;

    public GameObject loseText;

    private void Update()
    {
        if (health <= 0)
        {


            rb.gravityScale = 23;
            StartCoroutine(death());

        }



    }



    private IEnumerator death()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

}
