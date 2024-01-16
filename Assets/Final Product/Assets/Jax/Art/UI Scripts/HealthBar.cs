using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public Slider healthSlider;
    public Slider easeHealthSlider;

    private float lerpSpeed = 0.03f;

    void Update()
    {
        if (healthSlider.value != playerHealth.currentHealth)
        {
            healthSlider.value = playerHealth.currentHealth;
        }

        if(healthSlider.value != easeHealthSlider.value)
        {
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, playerHealth.currentHealth, lerpSpeed);
        }
    }
}
