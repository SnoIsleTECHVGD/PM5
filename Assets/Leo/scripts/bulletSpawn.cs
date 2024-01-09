using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class bulletSpawn : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject bulletPrefab;
    public Transform player;
    public float respawnTime = 1.0f;
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
        GameObject a = Instantiate(bulletPrefab,player.position,player.rotation) as GameObject;
        canShoot = false;
        if (transform.parent.parent.localScale.x < 0f)
        {
            a.GetComponent<shooting>().speed *= -1;
        }
<<<<<<< HEAD
        yield return new WaitForSeconds(0.12f);
=======

        yield return new WaitForSeconds(.75f);
        yield return new WaitForSeconds(0.75f);
>>>>>>> 239c0777b3b09747301b9af7778c457bf9c9e96d
        canShoot = true;

    }
}    
