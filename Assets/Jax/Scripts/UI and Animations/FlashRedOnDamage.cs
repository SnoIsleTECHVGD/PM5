using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashRedOnDamage : MonoBehaviour
{
    public SpriteRenderer player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FlashRed());
        }
    }

    public IEnumerator FlashRed()
    {
        player.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        player.color = Color.white;
    }
}
