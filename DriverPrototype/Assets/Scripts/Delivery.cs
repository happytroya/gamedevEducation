using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasMail;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oops");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Mail" && !hasMail)
        {
            Debug.Log("Mail picked up");
            hasMail = true;
            Destroy(other.gameObject);
        }
        else if(other.tag == "Customer" && hasMail)
        {
            Debug.Log("Mail delivered");
            hasMail = false;
        }
    }
}
