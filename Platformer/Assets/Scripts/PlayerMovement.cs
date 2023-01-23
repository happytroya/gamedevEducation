using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    Vector2 moveInput;
    Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Flip();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void Run()
    {
        Vector2 playerVelocty = new Vector2(moveInput.x * moveSpeed, playerRigidbody.velocity.y);
        playerRigidbody.velocity = playerVelocty;
    }

    void Flip()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(playerRigidbody.velocity.x) > Mathf.Epsilon;

        if(playerHasHorizontalSpeed)
        transform.localScale = new Vector2(Mathf.Sign(playerRigidbody.velocity.x), 1f);
    }
}
