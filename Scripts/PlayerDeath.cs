using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdeath : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ThemberChad")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            Debug.Log("collision detected");
        }
        if (collision.relativeVelocity.magnitude > 2)
        {

            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "ThemberChad")
        {
            Destroy(gameObject);
        }
    }
    */
}