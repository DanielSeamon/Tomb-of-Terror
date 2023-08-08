using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public float count = 0f;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ThemberChad")
        {
            count++;
        }
        if (count >= 5)
        {
            Application.LoadLevel("GameOver");
        }
    }
}
