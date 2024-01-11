using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lilboomerang : MonoBehaviour
{
    public float boomerangSpeed = 5f; // Adjust the speed of the boomerang
    public float rotationSpeed = 300f; // Adjust the rotation speed of the boomerang
    private bool isReturning = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !isReturning)
        {
            // Move the boomerang forward
            GetComponent<Rigidbody2D>().velocity = transform.right * boomerangSpeed;

            // Rotate the boomerang while moving forward
            GetComponent<Rigidbody2D>().angularVelocity = rotationSpeed;

            // Set a flag to indicate that the boomerang is on its way
            isReturning = true;

            // Schedule the boomerang to return after 4 seconds
            Invoke("ReturnToPlayer", 4f);
        }
    }

    void ReturnToPlayer()
    {
        // Stop the boomerang's linear motion
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        // Stop the rotation
        GetComponent<Rigidbody2D>().angularVelocity = 0f;

        // Schedule the reset after a delay
        Invoke("ResetBoomerang", 4f);
    }

    void ResetBoomerang()
    {
        // Stop the boomerang's motion
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        // Reset the rotation
        transform.rotation = Quaternion.identity;

        // Reset the flag
        isReturning = false;
    }

    void FixedUpdate()
    {
        // Check if the boomerang is returning
        if (isReturning)
        {
            // Find the player's position
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                // Calculate the direction from the boomerang to the player
                Vector2 direction = (player.transform.position - transform.position).normalized;

                // Move the boomerang towards the player
                GetComponent<Rigidbody2D>().velocity = direction * boomerangSpeed;
            }

        }
    }
}
