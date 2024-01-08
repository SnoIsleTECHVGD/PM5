using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnV2 : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject bulletPrefab;
    public Transform player;
    private bool canShoot = true;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) == true && canShoot)
        {
            StartCoroutine(cooldown());

        }


    }

    private IEnumerator cooldown()
    {
        GameObject a = Instantiate(bulletPrefab, player.position, player.rotation) as GameObject;
        new WaitForSeconds(2);
        canShoot = false;
        if (transform.parent.parent.localScale.x < 0f)
        {
            a.GetComponent<shooting>().speed *= -1;
        }
        yield return canShoot = true;

    }
}
