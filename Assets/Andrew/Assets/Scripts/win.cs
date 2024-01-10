using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public Text WINTEXT;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "WIN")
        {
            WINTEXT.gameObject.SetActive(true);
        }



    }




}
