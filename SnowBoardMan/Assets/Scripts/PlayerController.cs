using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueAmount = 10f;
    public float speedBooster = 30f;
    public float baseSpeed = 20f;


    Rigidbody2D playerRB;
    SurfaceEffector2D playerSurface;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerSurface = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControll();
        SpeedBoost();
    }

    private void SpeedBoost()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            playerSurface.speed = speedBooster;
        }
        else
        {
            playerSurface.speed = baseSpeed;
        }
    }

    private void PlayerControll()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerRB.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerRB.AddTorque(-torqueAmount);
        }
    }
}
