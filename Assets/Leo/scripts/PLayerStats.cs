using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerStats : Stats
{
   
    public Rigidbody2D rb;
    public GameObject loseText;

    private void Update()
    {
        if (health <= 0)
        {

            rb.gravityScale = 23;
            Death();





        }



    }
        private IEnumerator Death()
        {
          
            yield return new WaitForSeconds(4f);
            gameObject.SetActive(false);
        }
}
