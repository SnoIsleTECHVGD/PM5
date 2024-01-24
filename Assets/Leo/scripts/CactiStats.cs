using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactiStats :Stats
{

 

    public GameObject loseText;

    private void Update()
    {
        if (health <= 0)
        {
           StartCoroutine(death());


        }



    }

    private IEnumerator death()
    {
        GetComponent<Animator>().SetBool("isDead", true);
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
