using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject bulletPrefab;
    public Transform player;

    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) == true)
        {
            GameObject a = Instantiate(bulletPrefab,player.position,player.rotation) as GameObject;
        }

        
    }
}
