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

        if (Input.GetMouseButtonDown(0) == true && canShoot)
        {
            StartCoroutine(cooldown());
            
        }

        
    }

    private IEnumerator cooldown()
    {
        GameObject a = Instantiate(bulletPrefab,player.position,player.rotation) as GameObject;
        canShoot = false;
        yield return new WaitForSeconds(2);
        canShoot = true;

    }
}    
