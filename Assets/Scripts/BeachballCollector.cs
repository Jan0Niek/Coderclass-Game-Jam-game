using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachballCollector : MonoBehaviour
{
    private int count;
    public bool win;
    void Start()
    {
        count = 0;
        win = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BEACHBALL"))
        {
            count++;
            if (count >= 15)
            {
                win = true;
                Debug.Log("win");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BEACHBALL"))
        {
            count--;
        }
    }
}
