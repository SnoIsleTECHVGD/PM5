using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text3 : MonoBehaviour
{
    public GameObject text;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(true);
    }
}
