using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SationaryCactiStats : MonoBehaviour
{

    public float health;
    public float defense;
    public float attack;

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
        yield return new WaitForSeconds(1.1f);
        gameObject.SetActive(false);
    }
}
