using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScript : MonoBehaviour
{
    public MonoBehaviour[] Toggle;

    private int num1 = 1;
    private int num2 = 2;
    private int num3 = 3;
    private int num4 = 4;
    private int num5 = 5;
    private int num6 = 6;



    void Update()
    {
        if (Input.GetKeyDown(num1.ToString()))
        {
            Toggle[0].enabled = true;
            Toggle[0].gameObject.SetActive(true);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);
            Toggle[4].enabled = false;
            Toggle[4].gameObject.SetActive(false);
            Toggle[5].enabled = false;
            Toggle[5].gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(num2.ToString()))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = true;
            Toggle[1].gameObject.SetActive(true);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);
            Toggle[4].enabled = false;
            Toggle[4].gameObject.SetActive(false);
            Toggle[5].enabled = false;
            Toggle[5].gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(num3.ToString()))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = true;
            Toggle[2].gameObject.SetActive(true);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);
            Toggle[4].enabled = false;
            Toggle[4].gameObject.SetActive(false);
            Toggle[5].enabled = false;
            Toggle[5].gameObject.SetActive(false); ;

        }

        if (Input.GetKeyDown(num4.ToString()))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = true;
            Toggle[3].gameObject.SetActive(true);
            Toggle[4].enabled = false;
            Toggle[4].gameObject.SetActive(false);
            Toggle[5].enabled = false;
            Toggle[5].gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(num5.ToString()))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);
            Toggle[4].enabled = true;
            Toggle[4].gameObject.SetActive(true);
            Toggle[5].enabled = false;
            Toggle[5].gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(num6.ToString()))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);
            Toggle[4].enabled = false;
            Toggle[4].gameObject.SetActive(false);
            Toggle[5].enabled = true;
            Toggle[5].gameObject.SetActive(true);
        }

    }
}
