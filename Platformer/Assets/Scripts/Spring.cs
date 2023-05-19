using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public float springBoost = 25f;
    PlayerMovement playerMovement;
    Animator springAnimator;

    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        springAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
            springAnimator.SetBool("isColliding", true);
            playerMovement.playerRigidbody.velocity = new Vector2(0f, springBoost);
            Debug.Log(other + " entered");
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        springAnimator.SetBool("isColliding", false);
    }
}
