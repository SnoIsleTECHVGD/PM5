using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Stats playerHealth;
    public Slider healthSlider;
    public Slider easeHealthSlider;

    private float lerpSpeed = 0.03f;

    void Update()
    {
        if (healthSlider.value != playerHealth.health)
        {
            healthSlider.value = playerHealth.health;
        }

        if(healthSlider.value != easeHealthSlider.value)
        {
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, playerHealth.health, lerpSpeed);
        }
    }
}
