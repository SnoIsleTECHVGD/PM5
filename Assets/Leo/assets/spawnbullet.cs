using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbullet : MonoBehaviour
{


    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
    }
}
